using MangoAPI.Application.Interfaces;
using MangoAPI.Domain.Entities;
using System.Security.Cryptography;
using System.Text;

namespace MangoAPI.Application.Services;

public class PasswordService : IPasswordService
{
    public bool ValidateCredentials(UserEntity user, string currentPassword)
    {
        var hmac = new HMACSHA512(user.PasswordSalt);

        var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(currentPassword));

        var result = true;

        for (var i = 0; i < computedHash.Length; i++)
        {
            if (computedHash[i] != user.PasswordHash[i])
            {
                result = false;
            }
        }

        return result;
    }

    public UserEntity ChangePassword(UserEntity user, string newPassword)
    {
        var hmac = new HMACSHA512();

        user.PasswordSalt = hmac.Key;

        user.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(newPassword));

        return user;
    }
}