using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities
{
    public class UpdateChanelPictureCommandValidator : AbstractValidator<UpdateChanelPictureCommand>
    {
        public UpdateChanelPictureCommandValidator()
        {
            RuleFor(x => x.Image).NotEmpty();
        }
    }
}