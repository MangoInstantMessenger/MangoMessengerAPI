using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.DTO.Commands.Auth;
using MangoAPI.DTO.Responses.Auth;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.CommandHandlers.Auth
{
    public class RefreshTokenCommandHandler : IRequestHandler<RefreshTokenCommand, RefreshTokenResponse>
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly IJwtGenerator _jwtGenerator;
        private readonly IJwtRefreshService _jwtRefreshVerifier;
        private readonly IRequestMetadataService _metadataService;
        private readonly IFingerprintService _fingerprintService;

        public RefreshTokenCommandHandler(MangoPostgresDbContext postgresDbContext, IJwtGenerator jwtGenerator,
            IJwtRefreshService jwtRefreshVerifier, IRequestMetadataService metadataService,
            IFingerprintService fingerprintService)
        {
            _postgresDbContext = postgresDbContext;
            _jwtGenerator = jwtGenerator;
            _jwtRefreshVerifier = jwtRefreshVerifier;
            _metadataService = metadataService;
            _fingerprintService = fingerprintService;
        }

        public async Task<RefreshTokenResponse> Handle(RefreshTokenCommand request, CancellationToken cancellationToken)
        {
            var parsed = Guid.TryParse(request.RefreshTokenId, out _);

            if (!parsed)
            {
                return RefreshTokenResponse.InvalidOrEmptyRefreshToken;
            }

            var requestMetadata = _metadataService.GetRequestMetadata();

            VerifyTokenResult validationResult =
                await _jwtRefreshVerifier.VerifyUserRefreshTokenAsync(request.RefreshTokenId, requestMetadata,
                    cancellationToken);

            if (!validationResult.Success)
            {
                Console.WriteLine($"Fingerprint validated: {validationResult.FingerPrintValidated}");
                Console.WriteLine($"Agent validated: {validationResult.UserAgentValidated}");
                Console.WriteLine($"Token expired: {validationResult.RefreshTokenExpired}");
                return RefreshTokenResponse.SuspiciousAction;
            }

            var oldRefreshToken = validationResult.RefreshToken;

            var user = await _postgresDbContext.Users
                .FirstOrDefaultAsync(x => x.Id == oldRefreshToken.UserId, cancellationToken);

            if (user == null)
            {
                return RefreshTokenResponse.UserNotFound;
            }

            _postgresDbContext.Remove(oldRefreshToken);

            var newRefreshToken = _jwtGenerator.GenerateRefreshToken(requestMetadata.UserAgent,
                _fingerprintService.GetFingerprint(requestMetadata), requestMetadata.IpAddress);

            var newJwtToken = _jwtGenerator.GenerateJwtToken(user);

            newRefreshToken.UserId = user.Id;

            await _postgresDbContext.RefreshTokens.AddAsync(newRefreshToken, cancellationToken);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return RefreshTokenResponse.FromSuccess(newRefreshToken.Id, newJwtToken);
        }
    }
}