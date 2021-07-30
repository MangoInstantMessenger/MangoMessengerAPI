namespace MangoAPI.DTO.Responses.Chats
{
    public abstract record ChatResponseBase<T> : ResponseBase<T> where T : ResponseBase, new()
    {
    }
}