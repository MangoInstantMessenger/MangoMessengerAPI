namespace MangoAPI.BusinessLogic.Responses
{
    public abstract record ChatResponseBase<T> : ResponseBase<T>
        where T : ResponseBase, new();
}
