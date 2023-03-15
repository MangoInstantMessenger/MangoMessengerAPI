using FluentAssertions;
using FluentValidation;
using MangoAPI.UnitTests.Helpers;
using System;
using System.Linq;
using Xunit;

namespace MangoAPI.UnitTests.Domain.PersonalInformationEntity;

public class PersonalInformationTestsShouldThrow
{
    [Fact]
    public void PersonalInformationTestsShouldThrowUserIdEmpty()
    {
        var act = () => PersonalInfoHelper.CreateWithUserId(Guid.Empty);

        act.Should().ThrowExactly<ValidationException>();
    }

    [Theory]
    [InlineData(51)]
    [InlineData(52)]
    [InlineData(53)]
    public void PersonalInformationTestsShouldThrowFacebookOverflow(int size)
    {
        var facebook = new string(Enumerable.Repeat('a', size).ToArray());
        var act = () => PersonalInfoHelper.PersonalInfoUpdateWith(facebook: facebook);

        act.Should().ThrowExactly<ValidationException>();
    }

    [Theory]
    [InlineData(51)]
    [InlineData(52)]
    [InlineData(53)]
    public void PersonalInformationTestsShouldThrowTwitterOverflow(int size)
    {
        var twitter = new string(Enumerable.Repeat('a', size).ToArray());
        var act = () => PersonalInfoHelper.PersonalInfoUpdateWith(twitter: twitter);

        act.Should().ThrowExactly<ValidationException>();
    }

    [Theory]
    [InlineData(51)]
    [InlineData(52)]
    [InlineData(53)]
    public void PersonalInformationTestsShouldThrowInstagramOverflow(int size)
    {
        var instagram = new string(Enumerable.Repeat('a', size).ToArray());
        var act = () => PersonalInfoHelper.PersonalInfoUpdateWith(instagram: instagram);

        act.Should().ThrowExactly<ValidationException>();
    }

    [Theory]
    [InlineData(51)]
    [InlineData(52)]
    [InlineData(53)]
    public void PersonalInformationTestsShouldThrowLinkedInOverflow(int size)
    {
        var linkedIn = new string(Enumerable.Repeat('a', size).ToArray());
        var act = () => PersonalInfoHelper.PersonalInfoUpdateWith(linkedIn: linkedIn);
        
        act.Should().ThrowExactly<ValidationException>();
    }
}