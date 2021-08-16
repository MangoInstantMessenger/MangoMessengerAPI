using System;

namespace MangoAPI.Domain.Entities
{
    public sealed class SessionEntity
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public DateTime Expires { get; set; }
        public string RefreshToken { get; set; }
        public DateTime Created { get; set; }

        public bool IsExpired => DateTime.UtcNow >= Expires;

        public UserEntity UserEntity { get; set; }
    }
}