using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages;

public class DeleteMessageCommandValidator : AbstractValidator<DeleteMessageCommand>
{
    public DeleteMessageCommandValidator()
    {
        _ = RuleFor(x => x.ChatId).NotEmpty();
        _ = RuleFor(x => x.UserId).NotEmpty();
        _ = RuleFor(x => x.MessageId).NotEmpty();
    }
}