using MangoAPI.Domain.Constants;

namespace MangoAPI.DTO.Responses.Auth
{
    public class LoginResponse : ResponseBase
    {
        public string AccessToken { get; set; }
        public string RefreshTokenId { get; set; }

        public static LoginResponse InvalidEmail => new()
        {
            Message = ResponseMessageCodes.InvalidEmail,
            Success = false
        };

        public static LoginResponse InvalidPassword => new()
        {
            Message = ResponseMessageCodes.InvalidPassword,
            Success = false
        };

        public static LoginResponse UserUnverified => new()
        {
            Message = ResponseMessageCodes.UserUnverified,
            Success = false
        };

        public static LoginResponse FromSuccess(string accessToken, string refreshTokenId) => new()
        {
            Message = ResponseMessageCodes.Success,
            AccessToken = accessToken,
            RefreshTokenId = refreshTokenId,
            Success = true
        };
    }
}