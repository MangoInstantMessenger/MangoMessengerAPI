using System;

namespace MangoAPI.Domain.Entities;

public sealed class SessionEntity
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime ExpiresAt { get; set; }

    public bool IsExpired => DateTime.UtcNow >= ExpiresAt;

    public UserEntity UserEntity { get; set; }
}