using FluentAssertions;
using MangoAPI.Domain.Entities.ChatEntities;
using MangoAPI.Domain.Enums;
using System;
using Xunit;

namespace MangoAPI.UnitTests.Domain.UserChatEntityTests;

public class UserChatEntityTestSuccess
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    public void UserChatEntityCreateShouldSuccess(int roleId)
    {
        var role = (UserRole)roleId;
        Func<UserChatEntity> CreateSuccess = () => UserChatEntity.Create(Guid.NewGuid(), Guid.NewGuid(), role);

        CreateSuccess.Should().NotThrow();
    }
}