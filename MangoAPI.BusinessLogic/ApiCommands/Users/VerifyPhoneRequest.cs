using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record VerifyPhoneRequest
    {
        [JsonConstructor]
        public VerifyPhoneRequest(int confirmationCode)
        {
            ConfirmationCode = confirmationCode;
        }

        public int ConfirmationCode { get; }
    }
}
