namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    using MangoAPI.BusinessLogic.Responses;
    using MangoAPI.Domain.Constants;

    public record LoginResponse : ResponseBase<LoginResponse>
    {
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        // ReSharper disable once MemberCanBePrivate.Global
        public string AccessToken { get; init; }

        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        // ReSharper disable once MemberCanBePrivate.Global
        public string RefreshToken { get; init; }

        public static LoginResponse FromSuccess(string accessToken, string refreshToken)
        {
            return new ()
            {
                Message = ResponseMessageCodes.Success,
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                Success = true,
            };
        }
    }
}
