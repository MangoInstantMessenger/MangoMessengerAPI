using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages;

public class SendMessageCommandValidator : AbstractValidator<SendMessageCommand>
{
    public SendMessageCommandValidator()
    {
        RuleFor(x => x.Text)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .Length(1, 300);

        RuleFor(x => x.InReplyToUser)
            .Cascade(CascadeMode.Stop)
            .Length(1, 50);

        RuleFor(x => x.InReplyToText)
            .Cascade(CascadeMode.Stop)
            .Length(1, 300);

        RuleFor(x => x.ChatId).NotEmpty();
        RuleFor(x => x.UserId).NotEmpty();
    }
}