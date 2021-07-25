using MangoAPI.DTO.ApiCommands.Auth;

namespace MangoAPI.DTO.CommandModels.Auth
{
    public class RefreshTokenCommandModel
    {
        public string RefreshTokenId { get; set; }
    }

    public static class RefreshTokenCommandMapper
    {
        public static RefreshTokenCommand ToRefreshTokenCommand(this RefreshTokenCommandModel model) =>
            new()
            {
                RefreshTokenId = model.RefreshTokenId
            };
    }
}