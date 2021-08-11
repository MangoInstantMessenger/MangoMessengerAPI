namespace MangoAPI.BusinessLogic.Responses.UserInformation
{
    public abstract record UserInformationResponseBase<T> : ResponseBase<T> where T : ResponseBase, new();
}