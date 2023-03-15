using FluentAssertions;
using FluentValidation;
using MangoAPI.UnitTests.Helpers;
using System;
using System.Linq;
using Xunit;

namespace MangoAPI.UnitTests.Domain.UserEntityTests;

public class UserEntityTestsShouldThrow
{
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void CreateUserEntityThrowsEmptyUsername(string username)
    {
        var action = () => UserEntityHelper.CreateWithUsername(username);

        action.Should().ThrowExactly<ValidationException>();
    }

    [Theory]
    [InlineData(101)]
    [InlineData(102)]
    [InlineData(103)]
    public void CreateUserEntityThrowsUsernameOverflow(int size)
    {
        var username = new string(Enumerable.Repeat('a', size).ToArray());
        var act = () => UserEntityHelper.CreateWithUsername(username);

        act.Should().ThrowExactly<ValidationException>();
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    public void CreateUserEntityThrowsUsernameLess5Chars(int size)
    {
        var username = new string(Enumerable.Repeat('a', size).ToArray());
        var act = () => UserEntityHelper.CreateWithUsername(username);

        act.Should().ThrowExactly<ValidationException>();
    }

    [Fact]
    public void CreateUserEntityThrowsPasswordHashEmpty()
    {
        var actEmpty = () => UserEntityHelper.CreateWithPasswordHash(Array.Empty<byte>());
        var actNull = () => UserEntityHelper.CreateWithPasswordHash(null);

        actEmpty.Should().ThrowExactly<ValidationException>();
        actNull.Should().ThrowExactly<ValidationException>();
    }

    [Fact]
    public void CreateUserEntityThrowsPasswordSaltEmpty()
    {
        var actEmpty = () => UserEntityHelper.CreateWithPasswordSalt(Array.Empty<byte>());
        var actNull = () => UserEntityHelper.CreateWithPasswordSalt(null);

        actEmpty.Should().ThrowExactly<ValidationException>();
        actNull.Should().ThrowExactly<ValidationException>();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void CreateUserEntityThrowsImageFileEmpty(string imageFileName)
    {
        var act = () => UserEntityHelper.CreateWithImageFileName(imageFileName);

        act.Should().ThrowExactly<ValidationException>();
    }

    [Theory]
    [InlineData(101)]
    [InlineData(102)]
    [InlineData(103)]
    [InlineData(104)]
    public void CreateUserEntityThrowsImageFileOverflow(int size)
    {
        var imageFileName = new string(Enumerable.Repeat('a', size).ToArray());
        var act = () => UserEntityHelper.CreateWithImageFileName(imageFileName);

        act.Should().ThrowExactly<ValidationException>();
    }

    [Theory]
    [InlineData(101)]
    [InlineData(102)]
    [InlineData(103)]
    [InlineData(104)]
    public void CreateUserEntityThrowsDisplayNameOverflow(int size)
    {
        var displayName = new string(Enumerable.Repeat('a', size).ToArray());
        var act = () => UserEntityHelper.CreateWithDisplayName(displayName);

        act.Should().ThrowExactly<ValidationException>();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void CreateUserEntityThrowsDisplayNameEmpty(string displayName)
    {
        var act = () => UserEntityHelper.CreateWithDisplayName(displayName);

        act.Should().ThrowExactly<ValidationException>();
    }

    [Theory]
    [InlineData(121)]
    [InlineData(122)]
    [InlineData(123)]
    public void CreateUserEntityThrowsBioOverflow(int size)
    {
        var bio = new string(Enumerable.Repeat('a', size).ToArray());
        var act = () => UserEntityHelper.CreateWithBio(bio);

        act.Should().ThrowExactly<ValidationException>();
    }

    [Theory]
    [InlineData(101)]
    [InlineData(102)]
    [InlineData(103)]
    public void CreateUserEntityThrowsWebsiteOverflow(int size)
    {
        var website = new string(Enumerable.Repeat('a', size).ToArray());
        var act = () => UserEntityHelper.CreateWithWebsite(website);

        act.Should().ThrowExactly<ValidationException>();
    }

    [Theory]
    [InlineData(101)]
    [InlineData(102)]
    [InlineData(103)]
    public void CreateUserEntityThrowsAddressOverflow(int size)
    {
        var address = new string(Enumerable.Repeat('a', size).ToArray());
        var act = () => UserEntityHelper.CreateWithAddress(address);

        act.Should().ThrowExactly<ValidationException>();
    }
}