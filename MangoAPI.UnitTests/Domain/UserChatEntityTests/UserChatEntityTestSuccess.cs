using FluentAssertions;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using System;
using Xunit;

namespace MangoAPI.UnitTests.Domain.UserChatEntityTests;

public class UserChatEntityTestSuccess
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public void UserChatEntityCreateShouldSuccess(int roleId)
    {
        var role = (UserRole)roleId;
        Func<UserChatEntity> CreateSuccess = () => UserChatEntity.Create(Guid.NewGuid(), Guid.NewGuid(), role);

        CreateSuccess.Should().NotThrow();
    }
}