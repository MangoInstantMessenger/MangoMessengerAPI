using FluentValidation;

namespace MangoAPI.Domain.Entities.ChatEntities;

public class UserChatEntityValidator : AbstractValidator<UserChatEntity>
{
    public UserChatEntityValidator()
    {
        RuleFor(x => x.ChatId).NotEmpty();
        RuleFor(x => x.UserId).NotEmpty();
        RuleFor(x => x.RoleId).IsInEnum();
    }
}