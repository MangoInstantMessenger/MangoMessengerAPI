using System;
using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public class UpdateUserSocialInformationCommandValidator : AbstractValidator<UpdateUserSocialInformationCommand>
    {
        public UpdateUserSocialInformationCommandValidator()
        {
            RuleFor(x => x.UserId)
                .Must(x => Guid.TryParse(x, out _))
                .WithMessage("Update User Social Information: User Id can not be parsed");
        }
    }
}