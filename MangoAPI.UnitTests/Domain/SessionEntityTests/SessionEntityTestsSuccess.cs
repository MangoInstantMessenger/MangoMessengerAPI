using FluentAssertions;
using MangoAPI.UnitTests.Helpers;
using Xunit;

namespace MangoAPI.UnitTests.Domain.SessionEntityTests;

public class SessionEntityTestsSuccess
{
    [Fact]
    public void CreateSessionEntitySuccess()
    {
        var act = SessionEntityHelper.CreateSuccess;

        act.Should().NotThrow();
    }
}