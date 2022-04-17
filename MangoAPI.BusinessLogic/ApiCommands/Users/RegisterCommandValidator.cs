using FluentValidation;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
{
    private readonly string _mangoEmailNotificationsAddress;

    public RegisterCommandValidator(string mangoEmailNotificationsAddress)
    {
        _mangoEmailNotificationsAddress = mangoEmailNotificationsAddress;
    }
    
    public RegisterCommandValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty()
            .WithMessage("Email address required.")
            .EmailAddress()
            .WithMessage("Email address should be in proper format.")
            .NotEqual(_mangoEmailNotificationsAddress)
            .WithMessage("Prohibited email address")
            .Length(1, 50);

        RuleFor(x => x.Password)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .Length(1, 50);

        RuleFor(x => x.DisplayName)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .Length(1, 50);

        RuleFor(x => x.TermsAccepted).Equal(true);
    }
}