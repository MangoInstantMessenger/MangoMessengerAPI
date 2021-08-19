namespace MangoAPI.BusinessLogic.Responses
{
    public record MessageResponseBase<T> : ChatResponseBase<T>
        where T : ResponseBase, new();
}
