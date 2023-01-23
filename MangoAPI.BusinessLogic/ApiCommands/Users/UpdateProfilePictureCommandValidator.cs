using FluentValidation;
using MangoAPI.BusinessLogic.Pipelines;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class UpdateProfilePictureCommandValidator : AbstractValidator<UpdateProfilePictureCommand>
{
    public UpdateProfilePictureCommandValidator()
    {
        _ = RuleFor(x => x.UserId).NotEmpty();
        _ = RuleFor(x => x.ContentType).NotEmpty();

        _ = RuleFor(x => x.PictureFile)
            .NotNull()
            .SetValidator(new CommonImageValidator());
    }
}