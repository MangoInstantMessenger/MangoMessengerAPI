using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;

public class PasswordRestoreCommandValidator : AbstractValidator<PasswordRestoreCommand>
{
    public PasswordRestoreCommandValidator()
    {
        RuleFor(x => x.NewPassword)
            .Equal(x => x.RepeatPassword)
            .WithMessage("Passwords should be same.")
            .NotEmpty()
            .Length(8, 50)
            .WithMessage("Password must be at least 8 characters.");

        RuleFor(x => x.RequestId).NotEmpty();
    }
}
