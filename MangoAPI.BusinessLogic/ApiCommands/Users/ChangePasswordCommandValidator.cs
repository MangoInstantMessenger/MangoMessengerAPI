using FluentValidation;
using MangoAPI.Application.Services;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class ChangePasswordCommandValidator : AbstractValidator<ChangePasswordCommand>
{
    public ChangePasswordCommandValidator()
    {
        var passwordValidator = new PasswordValidatorService();

        RuleFor(x => x.CurrentPassword).NotEmpty();
        RuleFor(x => x.NewPassword).NotEmpty();
        RuleFor(x => x.RepeatNewPassword).NotEmpty();

        RuleFor(x => x.CurrentPassword)
            .NotEqual(x => x.NewPassword)
            .WithMessage("New and old passwords cannot be same")
            .Length(8, 50);

        RuleFor(x => x.NewPassword)
            .Equal(x => x.RepeatNewPassword)
            .WithMessage("New password and repeat password should be same.")
            .Must(passwordValidator.ValidatePassword)
            .WithMessage("Password must be at least 8 characters with: " +
                         "1 uppercase, 1 lowercase, 1 digit, 1 symbol.")
            .Length(8, 50);
    }
}