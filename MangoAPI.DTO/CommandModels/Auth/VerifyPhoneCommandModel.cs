namespace MangoAPI.DTO.CommandModels.Auth
{
    public class VerifyPhoneCommandModel
    {
        public int ConfirmationCode { get; set; }
        public string UserId { get; set; }
    }
}