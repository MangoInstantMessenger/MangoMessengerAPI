using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    public record LogoutRequest
    {
        [JsonConstructor]
        public LogoutRequest(string refreshToken)
        {
            RefreshToken = refreshToken;
        }

        public string RefreshToken { get; }
    }

    public static class LogoutCommandMapper
    {
        public static LogoutCommand ToCommand(this LogoutRequest model)
        {
            return new()
            {
                RefreshToken = model.RefreshToken
            };
        }
    }
}