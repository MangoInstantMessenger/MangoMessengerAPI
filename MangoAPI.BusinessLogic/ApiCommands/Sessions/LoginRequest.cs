using MangoAPI.Domain.Enums;
using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    public record LoginRequest
    {
        [JsonConstructor]
        public LoginRequest(string credential, VerificationMethod verificationMethod, 
            string password)
        {
            Credential = credential;
            VerificationMethod = verificationMethod;
            Password = password;
        }

        public string Credential { get; }
        public VerificationMethod VerificationMethod { get; }
        public string Password { get; }
    }

    public static class LoginCommandMapper
    {
        public static LoginCommand ToCommand(this LoginRequest model)
        {
            return new ()
            {
                Credential = model.Credential,
                VerificationMethod = model.VerificationMethod,
                Password = model.Password,
            };
        }
    }
}
