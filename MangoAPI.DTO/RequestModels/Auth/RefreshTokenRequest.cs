using MangoAPI.DTO.ApiCommands.Auth;

namespace MangoAPI.DTO.RequestModels.Auth
{
    public class RefreshTokenRequest
    {
        public string RefreshTokenId { get; set; }
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