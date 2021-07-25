using MangoAPI.DTO.ApiCommands.Auth;

namespace MangoAPI.DTO.CommandModels.Auth
{
    public class LogoutAllCommandModel
    {
        public string RefreshTokenId { get; set; }
    }

    public static class LogoutAllCommandMapper
    {
        public static LogoutAllCommand ToLogoutAllCommand(this LogoutAllCommandModel model) =>
            new LogoutAllCommand()
            {
                RefreshTokenId = model.RefreshTokenId
            };
    }
}