using Newtonsoft.Json;
using System;

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests
{
    public record PasswordRestoreRequest
    {
        public Guid RequestId { get; }
        public string NewPassword { get; }
        public string RepeatPassword { get; }

        [JsonConstructor]
        public PasswordRestoreRequest(Guid requestId, string newPassword, string repeatPassword)
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