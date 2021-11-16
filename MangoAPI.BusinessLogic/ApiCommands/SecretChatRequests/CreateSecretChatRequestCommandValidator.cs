using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.SecretChatRequests
{
    public class CreateSecretChatRequestCommandValidator : AbstractValidator<CreateSecretChatRequestCommand>
    {
        public CreateSecretChatRequestCommandValidator()
        {
            RuleFor(x => x.UserId).NotEmpty();
            RuleFor(x => x.RequestedUserId).NotEmpty();
            RuleFor(x => x.PublicKey).NotEmpty();
        }
    }
}