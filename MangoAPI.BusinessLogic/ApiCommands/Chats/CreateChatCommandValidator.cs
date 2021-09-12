using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Chats
{
    public class CreateChatCommandValidator : AbstractValidator<CreateChatCommand>
    {
        public CreateChatCommandValidator()
        {
            RuleFor(x => x.ChatType).IsInEnum();
        }
    }
}
