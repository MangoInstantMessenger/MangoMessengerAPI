namespace MangoAPI.DTO.CommandModels.Auth
{
    public class VerifyEmailCommandModel
    {
        public string Email { get; set; }
        public string UserId { get; set; }
    }
}