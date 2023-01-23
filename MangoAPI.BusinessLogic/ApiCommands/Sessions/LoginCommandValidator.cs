using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions;

public class LoginCommandValidator : AbstractValidator<LoginCommand>
{
    public LoginCommandValidator()
    {
        _ = RuleFor(x => x.Email)
            .EmailAddress()
            .WithMessage("Incorrect email address format.")
            .NotEmpty()
            .Length(1, 50);

        _ = RuleFor(x => x.Password)
            .NotEmpty()
            .Length(1, 50);
    }
}