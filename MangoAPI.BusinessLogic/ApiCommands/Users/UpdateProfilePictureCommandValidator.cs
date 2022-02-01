using System.Collections.Generic;
using FluentValidation;
using MangoAPI.BusinessLogic.Pipelines;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class UpdateProfilePictureCommandValidator : AbstractValidator<UpdateProfilePictureCommand>
{
    private readonly List<string> _allowedExtensions = new()
    {
        "jpg", "JPG", "png", "PNG"
    };

    public UpdateProfilePictureCommandValidator()
    {
        RuleFor(x => x.UserId).NotEmpty();
            
        RuleFor(x => x.PictureFile)
            .NotNull()
            .SetValidator(new CommonImageValidator());
    }
}