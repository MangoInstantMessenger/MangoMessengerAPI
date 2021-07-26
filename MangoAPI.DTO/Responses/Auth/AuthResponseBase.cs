namespace MangoAPI.DTO.Responses.Auth
{
    public abstract class AuthResponseBase<T> : ResponseBase<T> where T : ResponseBase, new()
    {
    }
}