using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Infrastructure.Database;
using MangoAPI.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.Services
{
    public class JwtRefreshService : IJwtRefreshService
    {
        private readonly MangoPostgresDbContext _postgresDbContext;

        public JwtRefreshService(MangoPostgresDbContext postgresDbContext)
        {
            _postgresDbContext = postgresDbContext;
        }

        public async Task<VerifyTokenResult> VerifyUserRefreshTokenAsync(string refreshTokenId, string userAgent, string fingerprint, string ipAddress,
            CancellationToken cancellationToken)
        {
            var token = await _postgresDbContext.RefreshTokens
                .FirstOrDefaultAsync(x =>
                    x.Id == refreshTokenId, cancellationToken);

            if (token == null)
                return VerifyTokenResult.NotVerified;

            return new VerifyTokenResult()
            {
                FingerPrintValidated = token.BrowserFingerprint == fingerprint,
                IpAddressValidated = token.IpAddress == ipAddress,
                UserAgentValidated = token.UserAgent == userAgent,
                RefreshTokenExpired = token.IsExpired,
                RefreshToken = token
            };
        }

        public async Task<RevokeTokenResult> RevokeRefreshTokenAsync(string refreshTokenId, CancellationToken cancellationToken)
        {
            var token = await _postgresDbContext.RefreshTokens.FirstOrDefaultAsync(x => x.Id == refreshTokenId, cancellationToken);
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