namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    using Newtonsoft.Json;

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
