using MangoAPI.Domain.Constants;
using MangoAPI.DTO.Models;

namespace MangoAPI.DTO.Responses.Messages
{
    public class SendMessageResponse: ResponseBase
    {
        public Message ChatMessage { get; set; }
        public static SendMessageResponse UserNotFound => new()
        {
            Message = ResponseMessageCodes.UserNotFound,
            Success = false
        };
        
        public static SendMessageResponse ChatNotFoundResponse => new()
        {
            Message = ResponseMessageCodes.ChatNotFound,
            Success = false
        };
        public static SendMessageResponse UserDontHavePermissions => new()
        {
            Message = ResponseMessageCodes.PermissionDenied,
            Success = false
        };

        public static SendMessageResponse FromSuccess(Message message) => new()
        {
            Success = true,
            Message = ResponseMessageCodes.Success,
            ChatMessage = message
        };
    }
}