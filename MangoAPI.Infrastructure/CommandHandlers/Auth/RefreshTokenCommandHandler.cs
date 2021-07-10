using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.Domain.Constants;
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
        private readonly ICookieService _cookieService;

        public RefreshTokenCommandHandler(MangoPostgresDbContext postgresDbContext,
            IJwtGenerator jwtGenerator,
            IJwtRefreshService jwtRefreshVerifier,
            IRequestMetadataService metadataService,
            IFingerprintService fingerprintService,
            ICookieService cookieService)
        {
            _postgresDbContext = postgresDbContext;
            _jwtGenerator = jwtGenerator;
            _jwtRefreshVerifier = jwtRefreshVerifier;
            _metadataService = metadataService;
            _fingerprintService = fingerprintService;
            _cookieService = cookieService;
        }

        public async Task<RefreshTokenResponse> Handle(RefreshTokenCommand request, CancellationToken cancellationToken)
        {
            var cookieToken = _cookieService.GetCookie(CookieConstants.MangoRefreshTokenId);
            
            var parsed = Guid.TryParse(cookieToken, out _);
            if (!parsed) 
                return RefreshTokenResponse.InvalidOrEmptyRefreshToken;
            
            var requestMetadata = _metadataService.GetRequestMetadata();
            var validationResult =
                await _jwtRefreshVerifier.VerifyUserRefreshTokenAsync(cookieToken, requestMetadata, cancellationToken);

            if (!validationResult.Success)
                return RefreshTokenResponse.InvalidOrEmptyRefreshToken;
            
            var token = validationResult.RefreshToken;

            var user = await _postgresDbContext.Users
                .FirstOrDefaultAsync(x => x.Id == token.UserId, cancellationToken);

            if (user == null)
                return RefreshTokenResponse.UserNotFound;

            var userTokens = _postgresDbContext.RefreshTokens
                .Where(x => x.UserId == user.Id);

            if (await userTokens.CountAsync(cancellationToken) >= 5)
            {
                _postgresDbContext.RefreshTokens.RemoveRange(userTokens);
            }

            var newRefreshToken = _jwtGenerator.GenerateRefreshToken(requestMetadata.UserAgent,
                _fingerprintService.GetFingerprint(requestMetadata), requestMetadata.IpAddress);

            var newJwtToken = _jwtGenerator.GenerateJwtToken(user);

            newRefreshToken.UserId = user.Id;

            token.Revoked = DateTime.Now;

            _postgresDbContext.RefreshTokens.Update(token);
            await _postgresDbContext.RefreshTokens.AddAsync(newRefreshToken, cancellationToken);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);

            return RefreshTokenResponse.FromSuccess(newRefreshToken.Id, newJwtToken);
        }
    }
}