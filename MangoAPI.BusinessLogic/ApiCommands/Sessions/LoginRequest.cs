namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    using Newtonsoft.Json;

    public record LoginRequest
    {
        [JsonConstructor]
        public LoginRequest(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public string Email { get; }
        public string Password { get; }
    }

    public static class LoginCommandMapper
    {
        public static LoginCommand ToCommand(this LoginRequest model)
        {
            return new ()
            {
                Email = model.Email,
                Password = model.Password,
            };
        }
    }
}
