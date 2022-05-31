using FluentValidation;
using MangoAPI.BusinessLogic.Pipelines;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class UpdateProfilePictureCommandValidator : AbstractValidator<UpdateProfilePictureCommand>
{

    public UpdateProfilePictureCommandValidator()
    {
        RuleFor(x => x.UserId).NotEmpty();
            
        RuleFor(x => x.PictureFile)
            .NotNull()
            .SetValidator(new CommonImageValidator());
    }
}