using MangoAPI.DTO.ApiCommands.Auth;

namespace MangoAPI.DTO.RequestModels.Auth
{
    public class LogoutAllRequest
    {
        public string RefreshTokenId { get; set; }
    }

    public static class LogoutAllCommandMapper
    {
        public static LogoutAllCommand ToCommand(this LogoutAllRequest model) =>
            new()
            {
                RefreshTokenId = model.RefreshTokenId
            };
    }
}