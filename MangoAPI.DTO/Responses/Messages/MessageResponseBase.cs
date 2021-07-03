using MangoAPI.Domain.Constants;
using MangoAPI.DTO.Responses.Chats;

namespace MangoAPI.DTO.Responses.Messages
{
    public class MessageResponseBase<T> : ChatResponseBase<T> where T : ResponseBase, new()
    {
        public static T MessageNotFound => new()
        {
            Message = ResponseMessageCodes.MessageNotFound,
            Success = false
        };
    }
}