using FluentValidation;
using MangoAPI.Application.Services;

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;

public class PasswordRestoreCommandValidator : AbstractValidator<PasswordRestoreCommand>
{
    public PasswordRestoreCommandValidator()
    {
        var passwordValidator = new PasswordValidatorService();

        RuleFor(x => x.NewPassword)
            .Equal(x => x.RepeatPassword)
            .WithMessage("Passwords should be same.")
            .NotEmpty()
            .Must(passwordValidator.ValidatePassword)
            .WithMessage("Password must be at least 8 characters with: 1 uppercase, 1 lowercase, 1 digit, 1 symbol.")
            .Length(8, 50);

        RuleFor(x => x.RequestId).NotEmpty();
    }
}
