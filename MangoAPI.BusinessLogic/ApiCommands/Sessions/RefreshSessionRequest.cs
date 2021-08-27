namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    using Newtonsoft.Json;

    public record RefreshSessionRequest
    {
        [JsonConstructor]
        public RefreshSessionRequest(string refreshToken)
        {
            RefreshToken = refreshToken;
        }

        public string RefreshToken { get; }
    }
}
