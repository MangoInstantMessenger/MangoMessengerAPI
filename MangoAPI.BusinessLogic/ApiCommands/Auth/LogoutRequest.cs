using Newtonsoft.Json;

namespace MangoAPI.DTO.ApiCommands.Auth
{
    public record LogoutRequest
    {
        [JsonConstructor]
        public LogoutRequest(string refreshTokenId)
        {
            RefreshTokenId = refreshTokenId;
        }

        public string RefreshTokenId { get; }
    }

    public static class LogoutCommandMapper
    {
        public static LogoutCommand ToCommand(this LogoutRequest model) =>
            new()
            {
                RefreshTokenId = model.RefreshTokenId
            };
    }
}