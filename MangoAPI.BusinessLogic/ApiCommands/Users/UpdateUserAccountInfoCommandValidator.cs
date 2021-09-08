using System;
using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public class UpdateUserAccountInfoCommandValidator : AbstractValidator<UpdateUserAccountInfoCommand>
    {
        public UpdateUserAccountInfoCommandValidator()
        {
            RuleFor(x => x.UserId)
                .Must(x => Guid.TryParse(x, out _))
                .WithMessage("Update User Account Info: User Id can not be parsed.");
        }
    }
}