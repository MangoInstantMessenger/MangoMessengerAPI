using MangoAPI.BusinessLogic.Responses.Chats;

namespace MangoAPI.BusinessLogic.Responses.Messages
{
    public record MessageResponseBase<T> : ChatResponseBase<T> where T : ResponseBase, new();
}