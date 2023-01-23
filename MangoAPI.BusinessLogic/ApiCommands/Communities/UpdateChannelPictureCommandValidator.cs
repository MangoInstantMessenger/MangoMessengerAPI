using FluentValidation;
using MangoAPI.BusinessLogic.Pipelines;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities;

public class UpdateChanelPictureCommandValidator : AbstractValidator<UpdateChanelPictureCommand>
{
    public UpdateChanelPictureCommandValidator()
    {
        _ = RuleFor(x => x.ChatId).NotEmpty();
        _ = RuleFor(x => x.UserId).NotEmpty();
        _ = RuleFor(x => x.ContentType).NotEmpty();

        _ = RuleFor(x => x.NewGroupPicture)
            .NotNull()
            .SetValidator(new CommonImageValidator());
    }
}
