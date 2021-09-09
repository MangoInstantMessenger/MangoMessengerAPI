using System;

namespace MangoAPI.Domain.Entities
{
    public class PasswordRestoreRequestEntity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ExpiresAt { get; set; }

        public bool IsValid => ExpiresAt >= DateTime.Now;

        public UserEntity UserEntity { get; set; }
    }
}