namespace MangoAPI.Domain.Entities
{
    using System;

    public sealed class SessionEntity
    {
        public string Id { get; set; }

        public string UserId { get; set; }

        public string RefreshToken { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ExpiresAt { get; set; }

        public bool IsExpired => DateTime.UtcNow >= ExpiresAt;

        public UserEntity UserEntity { get; set; }
    }
}