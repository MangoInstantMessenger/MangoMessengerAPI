using MangoAPI.Domain.Enums;
using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    public record LoginRequest
    {
        [JsonConstructor]
        public LoginRequest(string emailOrPhone, VerificationMethod verificationMethod, 
            string password)
        {
            EmailOrPhone = emailOrPhone;
            VerificationMethod = verificationMethod;
            Password = password;
        }

        public string EmailOrPhone { get; }
        public VerificationMethod VerificationMethod { get; }
        public string Password { get; }
    }

    public static class LoginCommandMapper
    {
        public static LoginCommand ToCommand(this LoginRequest model)
        {
            return new ()
            {
                EmailOrPhone = model.EmailOrPhone,
                VerificationMethod = model.VerificationMethod,
                Password = model.Password,
            };
        }
    }
}
