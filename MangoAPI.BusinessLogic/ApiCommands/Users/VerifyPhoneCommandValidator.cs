namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    using System;
    using FluentValidation;

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
