namespace MangoAPI.BusinessLogic.Responses
{
    public abstract record ContactsResponseBase<T> : ResponseBase<T> where T : ResponseBase, new();
}