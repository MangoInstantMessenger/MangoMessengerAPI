using FluentAssertions;
using MangoAPI.UnitTests.Helpers;
using Xunit;

namespace MangoAPI.UnitTests.Domain.UserEntityTests;

public class UserEntityTestsSuccess
{
    [Fact]
    public void CreateUserEntitySuccess()
    {
        var create = UserEntityHelper.Success;

        create.Should().NotThrow();
    }
}