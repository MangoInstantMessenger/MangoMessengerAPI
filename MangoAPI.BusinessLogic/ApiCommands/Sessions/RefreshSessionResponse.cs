namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    using Responses;
    using Domain.Constants;

    public record RefreshSessionResponse : AuthResponseBase<RefreshSessionResponse>
    {
        public string AccessToken { get; init; }
        
        public string RefreshToken { get; init; }

        public static RefreshSessionResponse FromSuccess(string accessToken, string refreshToken)
        {
            return new()
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                Message = ResponseMessageCodes.Success,
                Success = true,
            };
        }
    }
}
