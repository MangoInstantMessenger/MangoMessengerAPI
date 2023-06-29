using FluentValidation;
using System;
using Uuids;

namespace MangoAPI.Domain.Entities;

public sealed class SessionEntity
{
    public Guid Id { get; private set; }

    public Guid UserId { get; private set; }

    public DateTime CreatedAt { get; private set; }

    public DateTime ExpiresAt { get; private set; }

    public bool IsExpired => DateTime.UtcNow >= ExpiresAt;

    public UserEntity UserEntity { get; private set; }

    private SessionEntity()
    {
    }

    private SessionEntity(Guid userId, DateTime expiresAt)
    {
        Id = Uuid.NewMySqlOptimized().ToGuidByteLayout();
        CreatedAt = DateTime.UtcNow;
        UserId = userId;
        ExpiresAt = expiresAt;

        new SessionEntityValidator().ValidateAndThrow(this);
    }

    public static SessionEntity Create(Guid userId, DateTime expiresAt)
    {
        var session = new SessionEntity(userId, expiresAt);

        return session;
    }
}