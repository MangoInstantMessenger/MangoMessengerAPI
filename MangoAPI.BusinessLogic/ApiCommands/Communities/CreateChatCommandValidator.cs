using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities
{
    public class CreateChatCommandValidator : AbstractValidator<CreateChatCommand>
    {
        public CreateChatCommandValidator()
        {
            RuleFor(x => x.PartnerId).NotEmpty();
            RuleFor(x => x.UserId).NotEmpty();
            RuleFor(x => x.CommunityType).IsInEnum();
        }
    }
}
