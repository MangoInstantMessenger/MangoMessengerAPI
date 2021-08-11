using Newtonsoft.Json;

namespace MangoAPI.DTO.ApiCommands.Auth
{
    public record LogoutAllRequest
    {
        [JsonConstructor]
        public LogoutAllRequest(string refreshTokenId)
        {
            RefreshTokenId = refreshTokenId;
        }

        public string RefreshTokenId { get; }
    }

    public static class LogoutAllCommandMapper
    {
        public static LogoutAllCommand ToCommand(this LogoutAllRequest model, string userId) =>
            new()
            {
                RefreshTokenId = model.RefreshTokenId,
                UserId = userId
            };
    }
}