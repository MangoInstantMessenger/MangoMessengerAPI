using FluentValidation;

namespace MangoAPI.Domain.Entities.ChatEntities;

public class ChatEntityValidator : AbstractValidator<ChatEntity>
{
    public ChatEntityValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty()
            .MaximumLength(100);

        RuleFor(x => x.CommunityType)
            .IsInEnum();

        RuleFor(x => x.Description)
            .NotEmpty()
            .MaximumLength(100);

        RuleFor(x => x.Image)
            .MaximumLength(100);

        RuleFor(x => x.CreatedAt)
            .NotEmpty();

        RuleFor(x => x.MembersCount)
            .GreaterThanOrEqualTo(0);

        RuleFor(x => x.LastMessageText).MaximumLength(300);

        RuleFor(x => x.LastMessageAuthor).MaximumLength(50);
    }
}