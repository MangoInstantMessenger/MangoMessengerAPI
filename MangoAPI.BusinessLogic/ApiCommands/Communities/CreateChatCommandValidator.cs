using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities
{
    public class CreateChatCommandValidator : AbstractValidator<CreateChatCommand>
    {
        public CreateChatCommandValidator()
        {
            RuleFor(x => x.CommunityType).IsInEnum();
        }
    }
}
