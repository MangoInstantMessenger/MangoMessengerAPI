using System;
using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public class UpdateProfilePictureCommandValidator : AbstractValidator<UpdateProfilePictureCommand>
    {
        public UpdateProfilePictureCommandValidator()
        {
            RuleFor(x => x.UserId)
                .Must(x => Guid.TryParse(x, out _))
                .WithMessage("UpdateProfilePictureCommand: User Id can not be parsed.");

            RuleFor(x => x.Image).NotEmpty();
        }
    }
}