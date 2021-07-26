using FluentValidation;
using MangoAPI.DTO.ApiCommands.Chats;

namespace MangoAPI.Infrastructure.Validators.Chat
{
    public class CreateGroupCommandValidator : AbstractValidator<CreateGroupCommand>
    {
        public CreateGroupCommandValidator()
        {
            RuleFor(x => x.GroupTitle).NotNull().NotEmpty();
            RuleFor(x => x.GroupType).IsInEnum();
            RuleFor(x => x.UserId).NotNull().NotEmpty();
        }
    }
}