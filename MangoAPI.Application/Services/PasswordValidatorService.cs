using System.Linq;
using MangoAPI.Application.Interfaces;

namespace MangoAPI.Application.Services;

public class PasswordValidatorService : IPasswordValidatorService
{
    public bool ValidatePassword(string password)
    {
        return password.Length >= 8
               && password.Any(char.IsUpper)
               && password.Any(char.IsLower)
               && password.Any(char.IsDigit)
               && password.Any(char.IsSymbol)
               && password.Any(char.IsPunctuation);
    }
}