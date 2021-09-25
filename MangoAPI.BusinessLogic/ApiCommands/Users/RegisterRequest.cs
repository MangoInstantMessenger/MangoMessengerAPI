using System.ComponentModel;
using MangoAPI.Domain.Enums;
using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record RegisterRequest
    {
        [JsonConstructor]
        public RegisterRequest(
            string phoneNumber,
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

        [DefaultValue("549681386")]
        public string PhoneNumber { get; }
        
        [DefaultValue("test@gmail.com")]
        public string Email { get; }
        
        [DefaultValue("Test User")]
        public string DisplayName { get; }
        
        [DefaultValue("x[?6dME#xrp=nr7q")]
        public string Password { get; }
        
        [DefaultValue(2)]
        public VerificationMethod VerificationMethod { get; }
        
        [DefaultValue(true)]
        public bool TermsAccepted { get; }
    }
}
