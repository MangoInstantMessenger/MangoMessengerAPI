using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class ChangePasswordCommandValidator : AbstractValidator<ChangePasswordCommand>
{
    public ChangePasswordCommandValidator()
    {
        RuleFor(x => x.CurrentPassword).NotEmpty();
        RuleFor(x => x.NewPassword).NotEmpty();
        RuleFor(x => x.RepeatNewPassword).NotEmpty();

        RuleFor(x => x.CurrentPassword)
            .NotEqual(x => x.NewPassword)
            .WithMessage("New and old passwords cannot be same")
            .Length(5, 50)
            .WithMessage("Password must be at least 5 characters.");

        RuleFor(x => x.NewPassword)
            .Equal(x => x.RepeatNewPassword)
            .WithMessage("New password and repeat password should be same.")
            .Length(5, 50)
            .WithMessage("Password must be at least 5 characters.");
    }
}