using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public class VerifyPhoneCommandValidator : AbstractValidator<VerifyPhoneCommand>
    {
        public VerifyPhoneCommandValidator()
        {
            RuleFor(x => x.ConfirmationCode)
                .Cascade(CascadeMode.Stop)
                .NotEmpty();
        }
    }
}
