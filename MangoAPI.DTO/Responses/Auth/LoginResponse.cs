using MangoAPI.Domain.Constants;

namespace MangoAPI.DTO.Responses.Auth
{
    public class LoginResponse : ResponseBase<LoginResponse>
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

        public static LoginResponse FromSuccessWithData(string accessToken, string refreshTokenId) => new()
        {
            Message = ResponseMessageCodes.Success,
            AccessToken = accessToken,
            RefreshTokenId = refreshTokenId,
            Success = true
        };
    }
}