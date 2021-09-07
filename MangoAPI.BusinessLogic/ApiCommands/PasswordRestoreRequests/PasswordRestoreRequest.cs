using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests
{
    public record PasswordRestoreRequest
    {
        public string RequestId { get; }
        public string NewPassword { get; }
        public string RepeatPassword { get; }

        [JsonConstructor]
        public PasswordRestoreRequest(string requestId, string newPassword, string repeatPassword)
        {
            RequestId = requestId;
            NewPassword = newPassword;
            RepeatPassword = repeatPassword;
        }
    }

    public static class PasswordRestoreRequestMapper
    {
        public static PasswordRestoreCommand ToCommand(this PasswordRestoreRequest model) => new()
        {
            RequestId = model.RequestId,
            NewPassword = model.NewPassword,
            RepeatPassword = model.RepeatPassword
        };
    }
}