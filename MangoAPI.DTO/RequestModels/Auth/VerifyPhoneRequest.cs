using MangoAPI.DTO.ApiCommands.Auth;

namespace MangoAPI.DTO.RequestModels.Auth
{
    public record VerifyPhoneRequest
    {
        public int ConfirmationCode { get; set; }
        public string UserId { get; set; }
    }

    public static class VerifyPhoneCommandMapper
    {
        public static VerifyPhoneCommand ToCommand(this VerifyPhoneRequest model) =>
            new()
            {
                ConfirmationCode = model.ConfirmationCode,
                UserId = model.UserId
            };
    }
}