using MangoAPI.Domain.Constants;

namespace MangoAPI.DTO.Responses.Messages
{
    public class DeleteMessageResponse : ResponseBase
    {
        public static DeleteMessageResponse Suspicious => new()
        {
            Message = ResponseMessageCodes.SuspiciousAction,
            Success = false
        };

        public static DeleteMessageResponse RefreshTokenNotValidated => new()
        {
            Message = ResponseMessageCodes.InvalidOrEmptyRefreshToken,
            Success = false
        };

        public static DeleteMessageResponse UserNotFound => new()
        {
            Message = ResponseMessageCodes.UserNotFound,
            Success = false
        };

        public static DeleteMessageResponse MessageNotFound => new()
        {
            Message = ResponseMessageCodes.MessageNotFound,
            Success = false
        };

        public static DeleteMessageResponse FromSuccess => new()
        {
            Message = ResponseMessageCodes.Success,
            Success = true
        };
    }
}