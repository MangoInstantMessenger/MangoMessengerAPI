using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record ChangePasswordRequest
    {
        [JsonConstructor]
        public ChangePasswordRequest(string currentPassword, string newPassword)
        {
            CurrentPassword = currentPassword;
            NewPassword = newPassword;
        }

        public string CurrentPassword { get; }
        public string NewPassword { get; }
    }

    public static class ChangePasswordRequestMapper
    {
        public static ChangePasswordCommand ToCommand(this ChangePasswordRequest request, string userId) => new()
        {
            UserId = userId,
            CurrentPassword = request.CurrentPassword,
            NewPassword = request.NewPassword,
        };
    }
}