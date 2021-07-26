using MangoAPI.DTO.Responses.Chats;

namespace MangoAPI.DTO.Responses.Messages
{
    public class MessageResponseBase<T> : ChatResponseBase<T> where T : ResponseBase, new()
    {
    }
}