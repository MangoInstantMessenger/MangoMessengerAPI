using System;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record VerifyEmailRequest
    {
        [JsonConstructor]
        public VerifyEmailRequest(string email, Guid userId)
        {
            Email = email;
            UserId = userId;
        }

        [DefaultValue("test@gmail.com")]
        public string Email { get; }
        
        [DefaultValue("d1ab1de1-1aa8-4650-937c-4ed882038ad7")]
        public Guid UserId { get; }
    }
}