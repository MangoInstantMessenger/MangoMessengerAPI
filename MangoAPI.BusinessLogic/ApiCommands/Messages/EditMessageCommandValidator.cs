using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    public class EditMessageCommandValidator : AbstractValidator<EditMessageCommand>
    {
        public EditMessageCommandValidator()
        {
            RuleFor(x => x.ModifiedText)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 300);

            RuleFor(x => x.MessageId).NotEmpty();
            RuleFor(x => x.UserId).NotEmpty();
        }
    }
}