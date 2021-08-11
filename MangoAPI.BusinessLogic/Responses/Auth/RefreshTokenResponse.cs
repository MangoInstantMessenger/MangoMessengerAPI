using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.Responses.Auth
{
    public record RefreshTokenResponse : AuthResponseBase<RefreshTokenResponse>
    {
        // ReSharper disable once MemberCanBePrivate.Global
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string RefreshTokenId { get; init; }

        // ReSharper disable once MemberCanBePrivate.Global
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string AccessToken { get; init; }

        public static RefreshTokenResponse FromSuccess(string newRefreshTokenId, string newAccessToken) => new()
        {
            AccessToken = newAccessToken,
            RefreshTokenId = newRefreshTokenId,
            Message = ResponseMessageCodes.Success,
            Success = true
        };
    }
}