using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    public class DeleteMessageCommandValidator : AbstractValidator<DeleteMessageCommand>
    {
        public DeleteMessageCommandValidator()
        {
            RuleFor(x => x.ChatId).NotEmpty();
            RuleFor(x => x.UserId).NotEmpty();
            RuleFor(x => x.MessageId).NotEmpty();
        }
    }
}