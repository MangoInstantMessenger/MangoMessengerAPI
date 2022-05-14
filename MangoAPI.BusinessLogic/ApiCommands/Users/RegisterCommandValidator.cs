using FluentValidation;
using MangoAPI.Application.Services;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
{
    public RegisterCommandValidator()
    {
        var passwordValidator = new PasswordValidatorService();

        RuleFor(x => x.Email)
            .NotEmpty()
            .WithMessage("Email address required.")
            .EmailAddress()
            .WithMessage("Email address should be in proper format.")
            .Length(1, 50);

        RuleFor(x => x.Password)
            .NotEmpty()
            .Must(passwordValidator.ValidatePassword)
            .WithMessage("Password must be at least 8 characters with: " +
                         "1 uppercase, 1 lowercase, 1 digit, 1 symbol.")
            .Length(1, 50);

        RuleFor(x => x.DisplayName)
            .NotEmpty()
            .Length(1, 50);

        RuleFor(x => x.TermsAccepted).Equal(true);
    }
}