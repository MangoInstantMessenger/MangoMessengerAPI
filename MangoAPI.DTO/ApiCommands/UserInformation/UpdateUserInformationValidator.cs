using System;
using FluentValidation;

namespace MangoAPI.DTO.ApiCommands.UserInformation
{
    public class UpdateUserInformationValidator : AbstractValidator<UpdateUserInformationCommand>
    {
        public UpdateUserInformationValidator()
        {
            RuleFor(x => x.UserId).NotNull().NotEmpty();
            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("Update User Information: User Id cannot be parsed.");
        }
    }
}