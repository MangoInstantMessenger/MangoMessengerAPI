using FluentAssertions;
using FluentValidation;
using MangoAPI.UnitTests.Helpers;
using System;
using Xunit;

namespace MangoAPI.UnitTests.Domain.SessionEntityTests;

public class SessionEntityTestsShouldThrow
{
    [Fact]
    public void CreateSessionShouldThrowUserIdEmpty()
    {
        var act = () => SessionEntityHelper.CreateWithUserId(Guid.Empty);

        act.Should().Throw<ValidationException>();
    }

    [Fact]
    public void CreateSessionShouldThrowExpiresAtEmpty()
    {
        var act = () => SessionEntityHelper.CreateWithExpiresAt(DateTime.MinValue);

        act.Should().Throw<ValidationException>();
    }
}