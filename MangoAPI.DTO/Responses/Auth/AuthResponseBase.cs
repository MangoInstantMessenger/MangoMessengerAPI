namespace MangoAPI.DTO.Responses.Auth
{
    public abstract record AuthResponseBase<T> : ResponseBase<T> where T : ResponseBase, new()
    {
    }
}