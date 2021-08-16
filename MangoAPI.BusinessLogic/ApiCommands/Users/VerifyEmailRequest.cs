using System.Text.Json.Serialization;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record VerifyEmailRequest
    {
        [JsonConstructor]
        public VerifyEmailRequest(string email, string userId)
        {
            Email = email;
            UserId = userId;
        }

        public string Email { get; set; }
        public string UserId { get; set; }
    }

    public static class VerifyEmailRequestMapper
    {
        public static VerifyEmailCommand ToCommand(this VerifyEmailRequest model)
        {
            return new()
            {
                Email = model.Email,
                UserId = model.UserId
            };
        }
    }
}