using MangoAPI.DTO.ApiCommands.Auth;

namespace MangoAPI.DTO.CommandModels.Auth
{
    public class VerifyPhoneCommandModel
    {
        public int ConfirmationCode { get; set; }
        public string UserId { get; set; }
    }

    public static class VerifyPhoneCommandMapper
    {
        public static VerifyPhoneCommand ToVerifyPhoneCommand(this VerifyPhoneCommandModel model) =>
            new VerifyPhoneCommand()
            {
                ConfirmationCode = model.ConfirmationCode,
                UserId = model.UserId
            };
    }
}