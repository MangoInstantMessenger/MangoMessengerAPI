using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using System.Security.Cryptography;
using System.Text;

namespace MangoAPI.UnitTests.Helpers;

public static class UserEntityHelper
{
    public const string SeedPassword = "password123";
    public const string MangoSystemAccountUsername = "MangoMessenger";

    public static UserEntity Success()
    {
        var hmac = new HMACSHA512();

        const string displayName = "Mango Messenger";
        const DisplayNameColour displayColor = DisplayNameColour.Violet;
        const string imageFileName = "mango_logo.jpg";
        var passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(SeedPassword));
        var passwordSalt = hmac.Key;

        var mangoUser = UserEntity.Create(
            MangoSystemAccountUsername,
            passwordHash,
            passwordSalt,
            displayName,
            imageFileName,
            displayColor);

        return mangoUser;
    }

    public static UserEntity CreateWithUsername(string username)
    {
        var hmac = new HMACSHA512();

        const string displayName = "Mango Messenger";
        const DisplayNameColour displayColor = DisplayNameColour.Violet;
        const string imageFileName = "mango_logo.jpg";
        var passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(SeedPassword));
        var passwordSalt = hmac.Key;

        var mangoUser = UserEntity.Create(
            username,
            passwordHash,
            passwordSalt,
            displayName,
            imageFileName,
            displayColor);

        return mangoUser;
    }

    public static UserEntity CreateWithPasswordHash(byte[] passwordHash)
    {
        var hmac = new HMACSHA512();

        const string displayName = "Mango Messenger";
        const DisplayNameColour displayColor = DisplayNameColour.Violet;
        const string imageFileName = "mango_logo.jpg";
        var passwordSalt = hmac.Key;

        var mangoUser = UserEntity.Create(
            MangoSystemAccountUsername,
            passwordHash,
            passwordSalt,
            displayName,
            imageFileName,
            displayColor);

        return mangoUser;
    }

    public static UserEntity CreateWithPasswordSalt(byte[] salt)
    {
        var hmac = new HMACSHA512();

        const string displayName = "Mango Messenger";
        const DisplayNameColour displayColor = DisplayNameColour.Violet;
        const string imageFileName = "mango_logo.jpg";
        var passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(SeedPassword));

        var mangoUser = UserEntity.Create(
            MangoSystemAccountUsername,
            passwordHash,
            salt,
            displayName,
            imageFileName,
            displayColor);

        return mangoUser;
    }

    public static UserEntity CreateWithImageFileName(string imageFileName)
    {
        var hmac = new HMACSHA512();

        const string displayName = "Mango Messenger";
        const DisplayNameColour displayColor = DisplayNameColour.Violet;
        var passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(SeedPassword));
        var passwordSalt = hmac.Key;

        var mangoUser = UserEntity.Create(
            MangoSystemAccountUsername,
            passwordHash,
            passwordSalt,
            displayName,
            imageFileName,
            displayColor);

        return mangoUser;
    }

    public static UserEntity CreateWithDisplayName(string displayName)
    {
        var hmac = new HMACSHA512();

        const DisplayNameColour displayColor = DisplayNameColour.Violet;
        const string imageFileName = "mango_logo.jpg";
        var passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(SeedPassword));
        var passwordSalt = hmac.Key;

        var mangoUser = UserEntity.Create(
            MangoSystemAccountUsername,
            passwordHash,
            passwordSalt,
            displayName,
            imageFileName,
            displayColor);

        return mangoUser;
    }

    public static UserEntity CreateWithBio(string bio)
    {
        var hmac = new HMACSHA512();

        const string displayName = "Mango Messenger";
        const DisplayNameColour displayColor = DisplayNameColour.Violet;
        const string imageFileName = "mango_logo.jpg";
        var passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(SeedPassword));
        var passwordSalt = hmac.Key;

        var mangoUser = UserEntity.Create(
            MangoSystemAccountUsername,
            passwordHash,
            passwordSalt,
            displayName,
            imageFileName,
            displayColor);

        mangoUser.UpdateUserData(bio, null, null, null, MangoSystemAccountUsername);

        return mangoUser;
    }

    public static UserEntity CreateWithWebsite(string site)
    {
        var hmac = new HMACSHA512();

        const string displayName = "Mango Messenger";
        const DisplayNameColour displayColor = DisplayNameColour.Violet;
        const string imageFileName = "mango_logo.jpg";
        var passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(SeedPassword));
        var passwordSalt = hmac.Key;

        var mangoUser = UserEntity.Create(
            MangoSystemAccountUsername,
            passwordHash,
            passwordSalt,
            displayName,
            imageFileName,
            displayColor);

        mangoUser.UpdateUserData("my bio 228", site, null, null, MangoSystemAccountUsername);

        return mangoUser;
    }

    public static UserEntity CreateWithAddress(string address)
    {
        var hmac = new HMACSHA512();

        const string displayName = "Mango Messenger";
        const DisplayNameColour displayColor = DisplayNameColour.Violet;
        const string imageFileName = "mango_logo.jpg";
        var passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(SeedPassword));
        var passwordSalt = hmac.Key;

        var mangoUser = UserEntity.Create(
            MangoSystemAccountUsername,
            passwordHash,
            passwordSalt,
            displayName,
            imageFileName,
            displayColor);

        mangoUser.UpdateUserData("my bio 228", "username.com", null, address, MangoSystemAccountUsername);

        return mangoUser;
    }
}