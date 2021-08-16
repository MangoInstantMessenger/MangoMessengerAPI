using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.Auth
{
    public record LogoutRequest
    {
        [JsonConstructor]
        public LogoutRequest(string sessionId)
        {
            SessionId = sessionId;
        }

        public string SessionId { get; }
    }

    public static class LogoutCommandMapper
    {
        public static LogoutCommand ToCommand(this LogoutRequest model) =>
            new()
            {
                SessionId = model.SessionId
            };
    }
}