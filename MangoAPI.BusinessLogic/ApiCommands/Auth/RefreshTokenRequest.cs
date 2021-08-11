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
        public static RefreshTokenCommand ToCommand(this RefreshTokenRequest model) =>
            new()
            {
                RefreshTokenId = model.RefreshTokenId
            };
    }
}