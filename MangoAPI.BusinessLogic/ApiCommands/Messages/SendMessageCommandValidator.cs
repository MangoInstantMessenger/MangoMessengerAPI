using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages;

public class SendMessageCommandValidator : AbstractValidator<SendMessageCommand>
{
    public SendMessageCommandValidator()
    {
        _ = RuleFor(x => x.MessageText)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .Length(1, 300);

        _ = RuleFor(x => x.InReplayToAuthor)
            .Cascade(CascadeMode.Stop)
            .Length(1, 50);

        _ = RuleFor(x => x.InReplayToText)
            .Cascade(CascadeMode.Stop)
            .Length(1, 300);

        _ = RuleFor(x => x.AttachmentUrl)
            .Cascade(CascadeMode.Stop)
            .Length(1, 150);

        _ = RuleFor(x => x.ChatId).NotEmpty();
        _ = RuleFor(x => x.UserId).NotEmpty();
    }
}