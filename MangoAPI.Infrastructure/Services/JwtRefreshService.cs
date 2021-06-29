using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Common;
using MangoAPI.Application.Services;
using MangoAPI.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.Services
{
    public class JwtRefreshService : IJwtRefreshService
    {
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly IFingerprintService _fingerprintService;

        public JwtRefreshService(MangoPostgresDbContext postgresDbContext,IFingerprintService fingerprintService)
        {
            _postgresDbContext = postgresDbContext;
            _fingerprintService = fingerprintService;
        }

        public async Task<VerifyTokenResult> VerifyUserRefreshTokenAsync(string refreshTokenId, RequestMetadata requestMetadata, CancellationToken cancellationToken)
        {
            var token = await _postgresDbContext.RefreshTokens
                .FirstOrDefaultAsync(x =>
                    x.Id == refreshTokenId, cancellationToken);

            if (token == null)
                return VerifyTokenResult.NotVerified;

            return new VerifyTokenResult()
            {
                FingerPrintValidated = _fingerprintService.VerifyFingerPrint(requestMetadata,token.BrowserFingerprint),
                IpAddressValidated = token.IpAddress == requestMetadata.IpAddress,
                UserAgentValidated = token.UserAgent == requestMetadata.UserAgent,
                RefreshTokenExpired = token.IsExpired,
                RefreshToken = token
            };
        }

        public async Task<RevokeTokenResult> RevokeRefreshTokenAsync(string refreshTokenId, CancellationToken cancellationToken)
        {
            var token = await _postgresDbContext.RefreshTokens
                .FirstOrDefaultAsync(x => x.Id == refreshTokenId, cancellationToken);
            
            if (token is null)
            {
                return new RevokeTokenResult()
                {
                    Success = false
                };
            }
                
            _postgresDbContext.RefreshTokens.Remove(token);
            await _postgresDbContext.SaveChangesAsync(cancellationToken);
            return new RevokeTokenResult()
            {
                Success = true
            };
        }
    }
}