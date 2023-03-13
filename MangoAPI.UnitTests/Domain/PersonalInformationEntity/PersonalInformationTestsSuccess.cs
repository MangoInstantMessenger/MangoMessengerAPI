using FluentAssertions;
using Xunit;

namespace MangoAPI.UnitTests.Domain.PersonalInformationEntity;

public class PersonalInformationTestsSuccess
{
    [Fact]
    public void PersonalInformationTestsShouldCreateSuccess()
    {
        var create = Helpers.PersonalInfoHelper.CreateSuccess;

        create.Should().NotThrow();
    }
}