namespace MangoAPI.BusinessLogic.Responses.Contacts
{
    public abstract record ContactsResponseBase<T> : ResponseBase<T> where T : ResponseBase, new();
}