using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages;

public class SendMessageCommandValidator : AbstractValidator<SendMessageCommand>
{
    public SendMessageCommandValidator()
    {
        RuleFor(x => x.MessageText)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .Length(1, 300);

        RuleFor(x => x.InReplayToAuthor)
            .Cascade(CascadeMode.Stop)
            .Length(1, 50);

        RuleFor(x => x.InReplayToText)
            .Cascade(CascadeMode.Stop)
            .Length(1, 300);

        RuleFor(x => x.AttachmentUrl)
            .Cascade(CascadeMode.Stop);

        RuleFor(x => x.ChatId).NotEmpty();
        RuleFor(x => x.UserId).NotEmpty();
    }
}