namespace MangoAPI.BusinessLogic.Responses
{
    public abstract record UserInformationResponseBase<T> : ResponseBase<T> where T : ResponseBase, new();
}