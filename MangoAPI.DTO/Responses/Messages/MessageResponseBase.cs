using MangoAPI.DTO.Responses.Chats;

namespace MangoAPI.DTO.Responses.Messages
{
    public record MessageResponseBase<T> : ChatResponseBase<T> where T : ResponseBase, new();
}