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

            var validationResult =
                await _jwtRefreshVerifier.VerifyUserRefreshTokenAsync(request.RefreshTokenId, requestMetadata,
                    cancellationToken);

            if (!validationResult.Success)
            {
                return RefreshTokenResponse.InvalidOrEmptyRefreshToken;
            }

            var refreshToken = validationResult.RefreshToken;

            var user = await _postgresDbContext.Users
                .FirstOrDefaultAsync(x => x.Id == refreshToken.UserId, cancellationToken);

            if (user == null)
            {
                return RefreshTokenResponse.UserNotFound;
            }

            refreshToken = _jwtGenerator.GenerateRefreshToken(requestMetadata.UserAgent,
                _fingerprintService.GetFingerprint(requestMetadata), requestMetadata.IpAddress);

            var newJwtToken = _jwtGenerator.GenerateJwtToken(user);

            refreshToken.UserId = user.Id;

            _postgresDbContext.RefreshTokens.Update(refreshToken);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return RefreshTokenResponse.FromSuccess(refreshToken.Id, newJwtToken);
        }
    }
}