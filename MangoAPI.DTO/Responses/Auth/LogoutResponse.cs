using MangoAPI.Domain.Constants;

namespace MangoAPI.DTO.Responses.Auth
{
    public class LogoutResponse : ResponseBase
    {
        public static LogoutResponse RefreshTokenNotFoundResponse => new()
        {
            Success = false,
            Message = ResponseMessageCodes.LogoutTokenNotFound
        };

        public static LogoutResponse RefreshTokenNotValidated => new()
        {
            Success = false,
            Message = ResponseMessageCodes.LogoutTokenInvalid
        };

        public static LogoutResponse SuspiciousLogout => new()
        {
            Success = false,
            Message = ResponseMessageCodes.LogoutSuspiciousLogout
        };

        public static LogoutResponse SuccessResponse => new()
        {
            Success = true,
            Message = ResponseMessageCodes.Success
        };
    }
}