namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    using Responses;
    using Domain.Constants;

    public record RefreshSessionResponse : AuthResponseBase<RefreshSessionResponse>
    {
        // ReSharper disable once MemberCanBePrivate.Global
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string AccessToken { get; init; }

        // ReSharper disable once MemberCanBePrivate.Global
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
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
