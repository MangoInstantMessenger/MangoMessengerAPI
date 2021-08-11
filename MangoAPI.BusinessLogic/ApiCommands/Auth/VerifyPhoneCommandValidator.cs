using System;
using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Auth
{
    public class VerifyPhoneCommandValidator : AbstractValidator<VerifyPhoneCommand>
    {
        public VerifyPhoneCommandValidator()
        {
            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("Verify Phone code: User Id cannot be parsed.");

            RuleFor(x => x.ConfirmationCode)
                .Cascade(CascadeMode.Stop)
                .NotEmpty();
        }
    }
}