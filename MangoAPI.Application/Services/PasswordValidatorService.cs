using System.Linq;
using MangoAPI.Application.Interfaces;

namespace MangoAPI.Application.Services;

public class PasswordValidatorService : IPasswordValidatorService
{
    public bool ValidatePassword(string pass)
    {
        return pass.Length >= 8
               && pass.Any(char.IsUpper)
               && pass.Any(char.IsLower)
               && pass.Any(char.IsDigit)
               && pass.Any(char.IsSymbol)
               && pass.Any(char.IsPunctuation);
    }
}