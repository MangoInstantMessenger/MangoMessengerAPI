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

        public string Email { get; }
        public string UserId { get; }
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