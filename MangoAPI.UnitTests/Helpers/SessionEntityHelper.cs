using MangoAPI.Domain.Entities;
using System;

namespace MangoAPI.UnitTests.Helpers;

public static class SessionEntityHelper
{
    public static SessionEntity CreateSuccess()
    {
        return SessionEntity.Create(Guid.NewGuid(), DateTime.UtcNow.AddDays(1));
    }

    public static SessionEntity CreateWithUserId(Guid userId)
    {
        return SessionEntity.Create(userId, DateTime.UtcNow.AddDays(1));
    }

    public static SessionEntity CreateWithExpiresAt(DateTime expiresAt)
    {
        return SessionEntity.Create(Guid.NewGuid(), expiresAt);
    }
}