namespace MangoAPI.DTO.Responses.Contacts
{
    public abstract record ContactsResponseBase<T> : ResponseBase<T> where T : ResponseBase, new();
}