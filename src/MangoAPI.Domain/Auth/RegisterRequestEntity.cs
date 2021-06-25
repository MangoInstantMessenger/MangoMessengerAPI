using System;

namespace MangoAPI.Domain.Auth
{
    public class RegisterRequestEntity
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}