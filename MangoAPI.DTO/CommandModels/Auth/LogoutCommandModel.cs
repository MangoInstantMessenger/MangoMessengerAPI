using MangoAPI.DTO.ApiCommands.Auth;

namespace MangoAPI.DTO.CommandModels.Auth
{
    public class LogoutCommandModel
    {
        public string RefreshTokenId { get; set; }
    }

    public static class LogoutCommandMapper
    {
        public static LogoutCommand ToLogoutCommand(this LogoutCommandModel model) =>
            new()
            {
                RefreshTokenId = model.RefreshTokenId
            };
    }
}