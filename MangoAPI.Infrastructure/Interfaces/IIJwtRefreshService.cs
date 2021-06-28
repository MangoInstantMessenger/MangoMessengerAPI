using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Entities;

namespace MangoAPI.Infrastructure.Interfaces
{
    public interface IJwtRefreshService
    {
        public Task<VerifyTokenResult> VerifyUserRefreshTokenAsync(
            string refreshTokenId,
            string userAgent,
            string fingerprint,
            string ipAddress,
            CancellationToken cancellationToken);

        public Task<RevokeTokenResult> RevokeRefreshTokenAsync(string refreshTokenId,CancellationToken cancellationToken);
    }

    public class RevokeTokenResult
    {
        public bool Success { get; set; } 
    }

    public class VerifyTokenResult
    {
        public bool Success => FingerPrintValidated && IpAddressValidated && UserAgentValidated && !RefreshTokenExpired;
        public bool IsSuspicious => !Success && (!FingerPrintValidated || !IpAddressValidated || !UserAgentValidated);
        public bool RefreshTokenExpired { get; init; }
        public bool FingerPrintValidated { get; init; }
        public bool IpAddressValidated { get; init; }
        public bool UserAgentValidated { get; init; }
        public RefreshTokenEntity RefreshToken { get; init; }

        public static VerifyTokenResult NotVerified => new()
        {
            FingerPrintValidated = false,
            IpAddressValidated = false,
            RefreshTokenExpired = false,
            UserAgentValidated = false
        };
    }
}