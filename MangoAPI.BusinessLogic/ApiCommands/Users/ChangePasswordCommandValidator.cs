using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class ChangePasswordCommandValidator : AbstractValidator<ChangePasswordCommand>
{
    public ChangePasswordCommandValidator()
    {
        _ = RuleFor(x => x.CurrentPassword).NotEmpty();
        _ = RuleFor(x => x.NewPassword).NotEmpty();
        _ = RuleFor(x => x.RepeatNewPassword).NotEmpty();

        _ = RuleFor(x => x.CurrentPassword)
            .NotEqual(x => x.NewPassword)
            .WithMessage("New and old passwords cannot be same")
            .Length(8, 50);

        _ = RuleFor(x => x.NewPassword)
            .Equal(x => x.RepeatNewPassword)
            .WithMessage("New password and repeat password should be same.")
            .Length(8, 50)
            .WithMessage("Password must be at least 8 characters.");
    }
}
