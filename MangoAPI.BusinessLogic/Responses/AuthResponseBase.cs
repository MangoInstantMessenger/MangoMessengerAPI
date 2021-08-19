namespace MangoAPI.BusinessLogic.Responses
{
    public abstract record AuthResponseBase<T> : ResponseBase<T>
        where T : ResponseBase, new();
}
