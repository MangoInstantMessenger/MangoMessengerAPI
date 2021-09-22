using System.ComponentModel;
using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    public record LoginRequest
    {
        [JsonConstructor]
        public LoginRequest(string emailOrPhone, string password)
        {
            EmailOrPhone = emailOrPhone;
            Password = password;
        }

        [DefaultValue("test@gmail.com")]
        public string EmailOrPhone { get; }
        
        [DefaultValue("x[?6dME#xrp=nr7q")]
        public string Password { get; }
    }

    public static class LoginCommandMapper
    {
        public static LoginCommand ToCommand(this LoginRequest model)
        {
            return new()
            {
                EmailOrPhone = model.EmailOrPhone,
                Password = model.Password,
            };
        }
    }
}