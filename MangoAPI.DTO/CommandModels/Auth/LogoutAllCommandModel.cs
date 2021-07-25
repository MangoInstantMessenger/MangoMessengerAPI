namespace MangoAPI.DTO.CommandModels.Auth
{
    public class LogoutAllCommandModel
    {
        public string RefreshTokenId { get; set; }
        public string UserId { get; set; }
    }
}