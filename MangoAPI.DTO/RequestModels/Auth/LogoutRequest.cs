using MangoAPI.DTO.ApiCommands.Auth;

namespace MangoAPI.DTO.RequestModels.Auth
{
    public record LogoutRequest
    {
        public string RefreshTokenId { get; set; }
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