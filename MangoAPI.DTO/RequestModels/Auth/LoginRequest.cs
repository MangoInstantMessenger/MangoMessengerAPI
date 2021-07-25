using MangoAPI.DTO.ApiCommands.Auth;

namespace MangoAPI.DTO.RequestModels.Auth
{
    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public static class LoginCommandMapper
    {
        public static LoginCommand ToCommand(this LoginRequest model) =>
            new()
            {
                Email = model.Email,
                Password = model.Password
            };
    }
}