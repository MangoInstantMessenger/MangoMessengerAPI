using FluentAssertions;
using FluentValidation;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using System;
using Xunit;

namespace MangoAPI.UnitTests.Domain.UserChatEntityTests;

public class UserChatEntityTestsShouldThrow
{
    [Fact]
    public void UserChatEntityCreateShouldThrowChatIdEmpty()
    {
        var CreateChatIdEmpty =
            () => UserChatEntity.Create(Guid.NewGuid(), Guid.Empty, UserRole.User);

        CreateChatIdEmpty.Should().ThrowExactly<ValidationException>();
    }

    [Fact]
    public void UserChatEntityCreateShouldThrowUserIdEmpty()
    {
        var CreateUserIdEmpty =
            () => UserChatEntity.Create(Guid.Empty, Guid.NewGuid(), UserRole.User);

        CreateUserIdEmpty.Should().ThrowExactly<ValidationException>();
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(5)]
    [InlineData(6)]
    public void UserChatEntityCreateShouldThrowRoleOutOfRange(int role)
    {
        var enumRole = (UserRole)role;

        var CreateRoleOutOfRange =
            () => UserChatEntity.Create(Guid.NewGuid(), Guid.NewGuid(), enumRole);

        CreateRoleOutOfRange.Should().ThrowExactly<ValidationException>();
    }
}