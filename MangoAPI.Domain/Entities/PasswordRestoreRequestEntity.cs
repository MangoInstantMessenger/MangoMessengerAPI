using System;

namespace MangoAPI.Domain.Entities
{
    public class PasswordRestoreRequestEntity
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ExpiresAt { get; set; }

        public bool IsValid => ExpiresAt >= DateTime.Now;

        public UserEntity UserEntity { get; set; }
    }
}