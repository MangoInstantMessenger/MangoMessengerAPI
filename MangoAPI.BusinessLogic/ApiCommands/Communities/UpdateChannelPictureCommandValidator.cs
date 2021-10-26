using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities
{
    public class UpdateChanelPictureCommandValidator : AbstractValidator<UpdateChanelPictureCommand>
    {
        public UpdateChanelPictureCommandValidator()
        {
            RuleFor(x => x.Image)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 50);

            RuleFor(x => x.ChatId).NotEmpty();
            RuleFor(x => x.UserId).NotEmpty();
        }
    }
}