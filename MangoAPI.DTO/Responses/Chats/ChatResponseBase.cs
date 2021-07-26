namespace MangoAPI.DTO.Responses.Chats
{
    public abstract class ChatResponseBase<T> : ResponseBase<T> where T : ResponseBase, new()
    {
    }
}