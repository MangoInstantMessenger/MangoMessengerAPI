using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public class UpdateProfilePictureCommandValidator : AbstractValidator<UpdateProfilePictureCommand>
    {
        public UpdateProfilePictureCommandValidator()
        {
            RuleFor(x => x.Image)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 50);

            RuleFor(x => x.UserId).NotEmpty();
        }
    }
}