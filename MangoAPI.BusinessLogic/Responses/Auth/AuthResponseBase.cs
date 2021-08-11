namespace MangoAPI.BusinessLogic.Responses.Auth
{
    public abstract record AuthResponseBase<T> : ResponseBase<T> where T : ResponseBase, new();
}