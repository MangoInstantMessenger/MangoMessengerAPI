using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
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
            return new()
            {
                RefreshToken = model.RefreshToken,
                UserId = userId
            };
        }
    }
}