using MangoAPI.Domain.Enums;
using Newtonsoft.Json;
using System.ComponentModel;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record RegisterRequest
    {
        [JsonConstructor]
        public RegisterRequest(
            string email,
            string displayName,
            string password,
            bool termsAccepted)
        {
            Email = email;
            DisplayName = displayName;
            Password = password;
            TermsAccepted = termsAccepted;
        }

        [DefaultValue("test@gmail.com")]
        public string Email { get; }

        [DefaultValue("Test User")]
        public string DisplayName { get; }

        [DefaultValue("x[?6dME#xrp=nr7q")]
        public string Password { get; }

        [DefaultValue(true)]
        public bool TermsAccepted { get; }
    }
}