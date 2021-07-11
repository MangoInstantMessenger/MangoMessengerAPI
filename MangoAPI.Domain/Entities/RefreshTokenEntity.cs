using System;

namespace MangoAPI.Domain.Entities
{
    public class RefreshTokenEntity
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string UserAgent { get; set; }
        public string BrowserFingerprint { get; set; }
        public string IpAddress { get; set; }
        public string RefreshToken { get; set; }
        public DateTime Expires { get; set; }
        public DateTime Created { get; set; }

        public bool IsExpired => DateTime.UtcNow >= Expires;

        public virtual UserEntity UserEntity { get; set; }
    }
}