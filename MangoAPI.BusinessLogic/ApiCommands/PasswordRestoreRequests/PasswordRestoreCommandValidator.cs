using FluentValidation;
using System.Linq;

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests
{
    public class PasswordRestoreCommandValidator : AbstractValidator<PasswordRestoreCommand>
    {
        public PasswordRestoreCommandValidator()
        {
            RuleFor(x => x.NewPassword)
                .Equal(x => x.RepeatPassword)
                .WithMessage("Passwords should be same.")
                .NotEmpty()
                .Must(PasswordIsStrong)
                .WithMessage("Password must be at least 8 characters with: 1 uppercase, 1 lowercase, 1 digit, 1 symbol.")
                .Length(8, 50);

            RuleFor(x => x.RequestId).NotEmpty();
        }

        private static bool PasswordIsStrong(string pass)
        {
            return pass.Length >= 8
                && pass.Any(char.IsUpper)
                && pass.Any(char.IsLower)
                && pass.Any(char.IsDigit)
                && pass.Any(char.IsSymbol);
        }
    }
}