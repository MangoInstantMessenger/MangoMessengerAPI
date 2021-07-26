using FluentValidation;
using MangoAPI.DTO.ApiCommands.Chats;

namespace MangoAPI.Infrastructure.Validators.Chat
{
    public class CreateDirectChatCommandValidator : AbstractValidator<CreateDirectChatCommand>
    {
        public CreateDirectChatCommandValidator()
        {
            RuleFor(x => x.UserId).NotNull().NotEmpty();
            RuleFor(x => x.PartnerId).NotNull().NotEmpty();
        }
    }
}