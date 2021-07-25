using MangoAPI.DTO.ApiCommands.Auth;

namespace MangoAPI.DTO.CommandModels.Auth
{
    public class LoginCommandModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public static class LoginCommandMapper
    {
        public static LoginCommand ToLoginCommand(this LoginCommandModel model) =>
            new()
            {
                Email = model.Email,
                Password = model.Password
            };
    }
}