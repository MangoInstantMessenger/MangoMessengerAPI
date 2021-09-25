using System.ComponentModel;
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

        [DefaultValue("x[?6dME#xrp=nr7q")]
        public string CurrentPassword { get; }
        
        [DefaultValue("W[?64Ms#xdp=Qr7q")]
        public string NewPassword { get; }
    }
}