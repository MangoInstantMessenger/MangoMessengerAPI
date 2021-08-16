using MangoAPI.BusinessLogic.Enums;
using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record RegisterRequest
    {
        [JsonConstructor]
        public RegisterRequest(string phoneNumber,
            string email,
            string displayName,
            string password,
            VerificationMethod verificationMethod,
            bool termsAccepted)
        {
            PhoneNumber = phoneNumber;
            Email = email;
            DisplayName = displayName;
            Password = password;
            VerificationMethod = verificationMethod;
            TermsAccepted = termsAccepted;
        }

        public string PhoneNumber { get; }
        public string Email { get; }
        public string DisplayName { get; }
        public string Password { get; }
        public VerificationMethod VerificationMethod { get; }
        public bool TermsAccepted { get; }
    }

    public static class RegisterCommandMapper
    {
        public static RegisterCommand ToCommand(this RegisterRequest model)
        {
            return new()
            {
                PhoneNumber = model.PhoneNumber,
                Email = model.Email,
                DisplayName = model.DisplayName,
                Password = model.Password,
                VerificationMethod = model.VerificationMethod,
                TermsAccepted = model.TermsAccepted
            };
        }
    }
}