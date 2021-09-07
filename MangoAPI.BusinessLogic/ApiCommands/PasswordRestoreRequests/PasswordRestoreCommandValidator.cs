using FluentValidation;
using System;

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests
{
    public class PasswordRestoreCommandValidator : AbstractValidator<PasswordRestoreCommand>
    {
        public PasswordRestoreCommandValidator()
        {
            RuleFor(x => x.RequestId)
                .Must(x => Guid.TryParse(x, out _))
                .WithMessage("Password Restore: Request Id can not be parsed");

            RuleFor(x => x.NewPassword)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 300);

            RuleFor(x => x.RepeatPassword)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 300);
        }
    }
}