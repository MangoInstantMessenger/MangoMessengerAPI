using System.Linq;
using FluentValidation;
using MangoAPI.Application.Interfaces;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class ChangePasswordCommandValidator : AbstractValidator<ChangePasswordCommand>
{
    public ChangePasswordCommandValidator(IPasswordValidatorService passwordValidator)
    {
        RuleFor(x => x.CurrentPassword)
            .NotEqual(x => x.NewPassword)
            .WithMessage("New and old passwords cannot be same")
            .NotEmpty()
            .Length(8, 50);

        RuleFor(x => x.NewPassword)
            .Equal(x => x.RepeatNewPassword)
            .WithMessage("New password and repeat password should be same.")
            .Must(passwordValidator.ValidatePassword)
            .WithMessage("Password must be at least 8 characters with: " +
                         "1 uppercase, 1 lowercase, 1 digit, 1 symbol.")
            .NotEmpty()
            .Length(8, 50);
    }

    private static bool PasswordIsStrong(string pass)
    {
        return pass.Length >= 8
               && pass.Any(char.IsUpper)
               && pass.Any(char.IsLower)
               && pass.Any(char.IsDigit)
               && pass.Any(char.IsSymbol)
               && pass.Any(char.IsPunctuation);
    }
}