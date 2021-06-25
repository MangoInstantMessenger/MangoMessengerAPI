using System;

namespace MangoAPI.Domain.Entities
{
    public class RefreshTokenEntity
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Token { get; set; }
        public DateTime Expires { get; set; }
        public DateTime Created { get; set; }
        public string CreatedByIp { get; set; }
        public DateTime? Revoked { get; set; }
        public string RevokedByIp { get; set; }
        public string ReplacedByToken { get; set; }
        
        public bool IsActive => Revoked == null && !IsExpired;
        public bool IsExpired => DateTime.UtcNow >= Expires;
        
        public virtual UserEntity UserEntity { get; set; }
    }
}