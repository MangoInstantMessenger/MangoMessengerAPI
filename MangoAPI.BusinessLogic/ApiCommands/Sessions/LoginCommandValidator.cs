using FluentValidation;
using System.Linq;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions;

public class LoginCommandValidator : AbstractValidator<LoginCommand>
{
    public LoginCommandValidator()
    {
        RuleFor(x => x.Username)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .Must(username => username.All(char.IsLetterOrDigit))
            .WithMessage("Username must only contain letters or numbers.")
            .Length(1, 50)
            .WithMessage("Username must be between 1 and 50 characters.");

        RuleFor(x => x.Password)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .Length(8, 50)
            .WithMessage("Password must be at least 8 characters.");
    }
}