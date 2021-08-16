using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    public record RefreshSessionRequest
    {
        [JsonConstructor]
        public RefreshSessionRequest(string refreshToken)
        {
            RefreshToken = refreshToken;
        }

        public string RefreshToken { get; }
    }

    public static class RefreshTokenCommandMapper
    {
        public static RefreshSessionCommand ToCommand(this RefreshSessionRequest model)
        {
            return new()
            {
                RefreshToken = model.RefreshToken
            };
        }
    }
}