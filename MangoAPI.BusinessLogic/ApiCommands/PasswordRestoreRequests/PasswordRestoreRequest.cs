using Newtonsoft.Json;
using System;
using System.ComponentModel;

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests
{
    public record PasswordRestoreRequest
    {
        [DefaultValue("432d97fb-7df5-4adc-abdd-22f4f4d29198")]
        public Guid RequestId { get; }
        
        [DefaultValue("WzLxl534??]*&")]
        public string NewPassword { get; }
        
        [DefaultValue("WzLxl534??]*&")]
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