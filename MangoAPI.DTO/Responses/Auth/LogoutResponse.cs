using MangoAPI.Domain.Constants;

namespace MangoAPI.DTO.Responses.Auth
{
    public class LogoutResponse : ResponseBase
    {
        public static LogoutResponse InvalidOrEmptyRefreshToken => new()
        {
            Success = false,
            Message = ResponseMessageCodes.InvalidOrEmptyRefreshToken
        };

        public static LogoutResponse SuspiciousLogout => new()
        {
            Success = false,
            Message = ResponseMessageCodes.SuspiciousAction
        };

        public static LogoutResponse SuccessResponse => new()
        {
            Success = true,
            Message = ResponseMessageCodes.Success
        };
    }
}