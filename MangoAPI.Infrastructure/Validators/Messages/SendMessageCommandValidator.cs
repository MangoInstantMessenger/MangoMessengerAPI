using FluentValidation;
using MangoAPI.DTO.ApiCommands.Messages;

namespace MangoAPI.Infrastructure.Validators.Messages
{
    public class SendMessageCommandValidator : AbstractValidator<SendMessageCommand>
    {
        public SendMessageCommandValidator()
        {
            RuleFor(x => x.ChatId).NotNull().NotEmpty();
            RuleFor(x => x.MessageText).NotNull().NotEmpty();
            RuleFor(x => x.MessageText).MaximumLength(300);
            RuleFor(x => x.UserId).NotEmpty().NotEmpty();
        }
    }
}