using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
    {
        public RegisterCommandValidator()
        {
            RuleFor(x => x.Email)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 50);

            RuleFor(x => x.Password)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 50);

            RuleFor(x => x.DisplayName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 50);

            RuleFor(x => x.VerificationMethod).IsInEnum();

            RuleFor(x => x.PhoneNumber)
                .Cascade(CascadeMode.Stop)
                .NotEmpty();

            RuleFor(x => x.PhoneNumber).Must(x => x.Length <= 14);

            RuleFor(x => x.TermsAccepted).Equal(true);
        }
    }
}
