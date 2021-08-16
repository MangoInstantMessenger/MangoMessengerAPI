using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record VerifyPhoneRequest
    {
        [JsonConstructor]
        public VerifyPhoneRequest(int confirmationCode, string userId)
        {
            ConfirmationCode = confirmationCode;
        }

        public int ConfirmationCode { get; }
    }

    public static class VerifyPhoneCommandMapper
    {
        public static VerifyPhoneCommand ToCommand(this VerifyPhoneRequest model, string userId)
        {
            return new()
            {
                ConfirmationCode = model.ConfirmationCode,
                UserId = userId
            };
        }
    }
}