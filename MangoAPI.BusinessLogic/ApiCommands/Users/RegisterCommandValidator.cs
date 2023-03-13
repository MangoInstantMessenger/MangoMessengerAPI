using FluentValidation;
using System.Linq;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
{
    public RegisterCommandValidator()
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
            .Length(5, 50)
            .WithMessage("Password must be at least 5 characters.");
    }
}