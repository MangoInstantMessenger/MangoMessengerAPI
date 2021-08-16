using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.Auth
{
    public record LogoutAllRequest
    {
        [JsonConstructor]
        public LogoutAllRequest(string sessionId)
        {
            SessionId = sessionId;
        }

        public string SessionId { get; }
    }

    public static class LogoutAllCommandMapper
    {
        public static LogoutAllCommand ToCommand(this LogoutAllRequest model, string userId) =>
            new()
            {
                SessionId = model.SessionId,
                UserId = userId
            };
    }
}