using FluentValidation;

namespace MangoAPI.Domain.Entities;

public class MessageEntityValidator : AbstractValidator<MessageEntity>
{
    public MessageEntityValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.Text).NotEmpty().MaximumLength(300);
        RuleFor(x => x.ChatId).NotEmpty();
        RuleFor(x => x.UserId).NotEmpty();
        RuleFor(x => x.InReplyToUser).MaximumLength(50);
        RuleFor(x => x.InReplyToText).MaximumLength(300);
        RuleFor(x => x.AttachmentFileName).MaximumLength(100);
    }
}