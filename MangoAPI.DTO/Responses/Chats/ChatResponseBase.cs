using MangoAPI.Domain.Constants;

namespace MangoAPI.DTO.Responses.Chats
{
    public abstract class ChatResponseBase<T> : ResponseBase<T> where T : ResponseBase, new()
    {
        public static T PermissionDenied => new()
        {
            Message = ResponseMessageCodes.PermissionDenied,
            Success = false
        };
        
        public static T ChatNotFound => new()
        {
            Message = ResponseMessageCodes.ChatNotFound,
            Success = false
        };
    }
}