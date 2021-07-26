using FluentValidation;
using MangoAPI.DTO.ApiCommands.Chats;

namespace MangoAPI.Infrastructure.Validators.Chat
{
    public class JoinChatCommandValidator : AbstractValidator<JoinChatCommand>
    {
        public JoinChatCommandValidator()
        {
            RuleFor(x => x.ChatId).NotNull().NotEmpty();
        }
    }
}