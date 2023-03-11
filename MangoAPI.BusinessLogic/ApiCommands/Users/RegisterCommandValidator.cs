using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
{
    public RegisterCommandValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty()
            .WithMessage("Email address required.")
            .EmailAddress()
            .WithMessage("Email address should be in proper format.")
            .Length(1, 50);

        RuleFor(x => x.Password)
            .NotEmpty()
            .Length(8, 50)
            .WithMessage("Password must be at least 8 characters.");

        RuleFor(x => x.DisplayName)
            .NotEmpty()
            .Length(1, 50);
    }
}
