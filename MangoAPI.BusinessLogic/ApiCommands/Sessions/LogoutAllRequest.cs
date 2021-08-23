namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    using Newtonsoft.Json;

    public record LogoutAllRequest
    {
        [JsonConstructor]
        public LogoutAllRequest(string refreshToken)
        {
            RefreshToken = refreshToken;
        }

        public string RefreshToken { get; }
    }
}
