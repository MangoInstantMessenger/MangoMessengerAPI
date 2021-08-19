namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    using MangoAPI.BusinessLogic.Responses;
    using MangoAPI.Domain.Constants;

    public record RegisterResponse : AuthResponseBase<RegisterResponse>
    {
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        // ReSharper disable once MemberCanBePrivate.Global
        public string AccessToken { get; init; }

        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        // ReSharper disable once MemberCanBePrivate.Global
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
