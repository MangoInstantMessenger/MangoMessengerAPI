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

        public string EmailOrPhone { get; }
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