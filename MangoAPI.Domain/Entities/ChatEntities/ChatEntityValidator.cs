using FluentValidation;

namespace MangoAPI.Domain.Entities.ChatEntities;

public class ChatEntityValidator : AbstractValidator<ChatEntity>
{
    public ChatEntityValidator()
    {
        RuleFor(x => x.Title).NotEmpty();

        RuleFor(x => x.CommunityType).IsInEnum();

        RuleFor(x => x.Description)
            .NotEmpty()
            .WithMessage("Description is required.")
            .MaximumLength(100)
            .WithMessage("Description cannot exceed 100 characters.");

        RuleFor(x => x.Image).MaximumLength(100)
            .WithMessage("Image cannot exceed 100 characters.");

        RuleFor(x => x.CreatedAt).NotEmpty();

        RuleFor(x => x.MembersCount).GreaterThanOrEqualTo(0);
    }
}