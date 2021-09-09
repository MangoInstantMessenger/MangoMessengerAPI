using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public class UpdateProfilePictureCommandValidator : AbstractValidator<UpdateProfilePictureCommand>
    {
        public UpdateProfilePictureCommandValidator()
        {
            RuleFor(x => x.Image).NotEmpty();
        }
    }
}