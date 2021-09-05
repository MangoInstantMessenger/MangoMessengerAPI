using System;
using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests
{
    public class RestorePasswordCommandValidator : AbstractValidator<RestorePasswordCommand>
    {
        public RestorePasswordCommandValidator()
        {
            RuleFor(x => x.EmailOrPhone)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 300);
        }
    }
}