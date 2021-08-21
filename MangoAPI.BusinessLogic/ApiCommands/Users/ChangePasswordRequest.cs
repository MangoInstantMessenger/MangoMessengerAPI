namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record ChangePasswordRequest
    {
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }

        public ChangePasswordRequest(string currentPassword, string newPassword)
        {
            CurrentPassword = currentPassword;
            NewPassword = newPassword;
        }
    }

    public static class ChangePasswordRequestMapper
    {
        public static ChangePasswordCommand ToCommand(this ChangePasswordRequest request, string userId) => new ()
        {
            UserId = userId,
            CurrentPassword = request.CurrentPassword,
            NewPassword = request.NewPassword,
        };
    }
}
