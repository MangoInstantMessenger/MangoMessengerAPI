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

    public static class LogoutAllCommandMapper
    {
        public static LogoutAllCommand ToCommand(this LogoutAllRequest model, string userId)
        {
            return new ()
            {
                UserId = userId,
            };
        }
    }
}
