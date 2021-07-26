using FluentValidation;
using MangoAPI.DTO.ApiCommands.Messages;

namespace MangoAPI.Infrastructure.Validators.Messages
{
    public class EditMessageCommandValidator : AbstractValidator<EditMessageCommand>
    {
        public EditMessageCommandValidator()
        {
            RuleFor(x => x.MessageId).NotNull().NotEmpty();
            RuleFor(x => x.ModifiedText).NotNull().NotEmpty();
            RuleFor(x => x.ModifiedText).MaximumLength(300);
        }
    }
}