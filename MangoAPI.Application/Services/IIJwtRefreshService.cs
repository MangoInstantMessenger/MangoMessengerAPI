using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Common;
using MangoAPI.Domain.Entities;

namespace MangoAPI.Application.Services
{
    public interface IJwtRefreshService
    {
        public Task<VerifyTokenResult> VerifyUserRefreshTokenAsync(
            string refreshTokenId,
            RequestMetadata requestMetadata,
            CancellationToken cancellationToken);

        public Task<RevokeTokenResult> RevokeRefreshTokenAsync(string refreshTokenId,
            CancellationToken cancellationToken);
    }

    public class RevokeTokenResult
    {
        public bool Success { get; set; }
    }

    public class VerifyTokenResult
    {
        public bool Success => FingerPrintValidated && UserAgentValidated && !RefreshTokenExpired;
        public bool IsSuspicious => !Success && (!FingerPrintValidated || !UserAgentValidated);
        public bool RefreshTokenExpired { get; init; }
        public bool FingerPrintValidated { get; init; }
        public bool UserAgentValidated { get; init; }
        public RefreshTokenEntity RefreshToken { get; init; }

        public static VerifyTokenResult NotVerified => new()
        {
            FingerPrintValidated = false,
            RefreshTokenExpired = false,
            UserAgentValidated = false
        };
    }
}