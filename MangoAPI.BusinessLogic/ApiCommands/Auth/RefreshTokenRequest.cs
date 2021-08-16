using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.Auth
{
    public record RefreshTokenRequest
    {
        [JsonConstructor]
        public RefreshTokenRequest(string refreshTokenId)
        {
            RefreshTokenId = refreshTokenId;
        }

        public string RefreshTokenId { get; }
    }

    public static class RefreshTokenCommandMapper
    {
        public static RefreshSessionCommand ToCommand(this RefreshTokenRequest model) =>
            new()
            {
                SessionId = model.RefreshTokenId
            };
    }
}