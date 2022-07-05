using FluentValidation;
using MangoAPI.BusinessLogic.Pipelines;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities;

public class UpdateChanelPictureCommandValidator : AbstractValidator<UpdateChanelPictureCommand>
{
    public UpdateChanelPictureCommandValidator()
    {
        RuleFor(x => x.ChatId).NotEmpty();
        RuleFor(x => x.UserId).NotEmpty();
        RuleFor(x => x.ContentType).NotEmpty();

        RuleFor(x => x.NewGroupPicture)
            .NotNull()
            .SetValidator(new CommonImageValidator());
    }
}
