using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities
{
    public class UpdateChanelPictureCommandValidator : AbstractValidator<UpdateChanelPictureCommand>
    {
        public UpdateChanelPictureCommandValidator()
        {
            RuleFor(x => x.Image).NotEmpty();
            RuleFor(x => x.ChatId).NotEmpty();
            RuleFor(x => x.UserId).NotEmpty();
        }
    }
}