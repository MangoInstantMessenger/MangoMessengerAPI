using MangoAPI.Domain.Constants;

namespace MangoAPI.DTO.Responses.Auth
{
    public class RefreshTokenResponse : ResponseBase
    {
        public string RefreshTokenId { get; set; }
        public string AccessToken { get; set; }
        
        public static RefreshTokenResponse InvalidRefreshToken => new()
        {
            Success = false,
            Message = ResponseMessageCodes.InvalidRefreshTokenProvided
        };
        
        public static RefreshTokenResponse UserNotFoundForToken => new()
        {
            Success = false,
            Message = ResponseMessageCodes.RefreshTokenUserNotFound
        };

        public static RefreshTokenResponse FromSuccess(string newRefreshTokenId, string newAccessToken) => new()
        {
            AccessToken = newAccessToken,
            RefreshTokenId = newRefreshTokenId,
            Message = ResponseMessageCodes.Success,
            Success = true
        };
    }
}