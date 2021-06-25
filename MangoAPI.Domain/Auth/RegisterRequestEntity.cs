using System;

namespace MangoAPI.Domain.Auth
{
    public class RegisterRequestEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ConfirmLinkCode { get; set; }
    }
}