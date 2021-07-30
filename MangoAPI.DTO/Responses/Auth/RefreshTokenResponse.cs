using MangoAPI.Domain.Constants;

namespace MangoAPI.DTO.Responses.Auth
{
    public record RefreshTokenResponse : AuthResponseBase<RefreshTokenResponse>
    {
        public string RefreshTokenId { get; set; }
        public string AccessToken { get; set; }

        public static RefreshTokenResponse FromSuccess(string newRefreshTokenId, string newAccessToken) => new()
        {
            AccessToken = newAccessToken,
            RefreshTokenId = newRefreshTokenId,
            Message = ResponseMessageCodes.Success,
            Success = true
        };
    }
}