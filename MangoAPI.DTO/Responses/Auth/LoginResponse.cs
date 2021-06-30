using MangoAPI.Domain.Constants;

namespace MangoAPI.DTO.Responses.Auth
{
    public class LoginResponse : ResponseBase
    {
        public string AccessToken { get; set; }
        public string RefreshTokenId { get; set; }

        public static LoginResponse InvalidEmail => new()
        {
            Message = ResponseMessageCodes.LoginInvalidEmail,
            Success = false
        };

        public static LoginResponse InvalidPassword => new()
        {
            Message = ResponseMessageCodes.LoginInvalidPassword,
            Success = false
        };

        public static LoginResponse Unverified => new()
        {
            Message = ResponseMessageCodes.Unverified,
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