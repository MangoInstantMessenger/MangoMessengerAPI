using MangoAPI.Domain.Constants;

namespace MangoAPI.DTO.Responses.Messages
{
    public class EditMessageResponse : ResponseBase
    {
        public static EditMessageResponse Suspicious => new()
        {
            Message = ResponseMessageCodes.Success,
            Success = false
        };

        public static EditMessageResponse RefreshTokenNotValidated => new()
        {
            Message = ResponseMessageCodes.InvalidOrEmptyRefreshToken,
            Success = false
        };

        public static EditMessageResponse UserNotFound => new()
        {
            Message = ResponseMessageCodes.UserNotFound,
            Success = false
        };

        public static EditMessageResponse MessageNotFound => new()
        {
            Message = ResponseMessageCodes.MessageNotFound,
            Success = false
        };

        public static EditMessageResponse FromSuccess => new()
        {
            Message = ResponseMessageCodes.Success,
            Success = true
        };
    }
}