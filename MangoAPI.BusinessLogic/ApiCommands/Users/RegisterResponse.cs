namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    using Responses;
    using Domain.Constants;

    public record RegisterResponse : AuthResponseBase<RegisterResponse>
    {
        public string AccessToken { get; init; }
        
        public string RefreshToken { get; init; }

        public static RegisterResponse FromSuccess(string accessToken, string refreshToken)
        {
            return new ()
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                Success = true,
                Message = ResponseMessageCodes.Success,
            };
        }
    }
}
