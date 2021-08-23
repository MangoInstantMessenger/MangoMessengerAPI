namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    using Newtonsoft.Json;

    public record LogoutRequest
    {
        [JsonConstructor]
        public LogoutRequest(string refreshToken)
        {
            RefreshToken = refreshToken;
        }

        public string RefreshToken { get; }
    }
}
