﻿using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests
{
    public class PasswordRestoreCommandValidator : AbstractValidator<PasswordRestoreCommand>
    {
        public PasswordRestoreCommandValidator()
        {
            RuleFor(x => x.NewPassword)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 50);

            RuleFor(x => x.RepeatPassword)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 50);

            RuleFor(x => x.RequestId).NotEmpty();
        }
    }
}