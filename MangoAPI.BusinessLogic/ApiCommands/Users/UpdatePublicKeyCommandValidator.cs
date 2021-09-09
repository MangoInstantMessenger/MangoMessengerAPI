using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public class UpdatePublicKeyCommandValidator : AbstractValidator<UpdatePublicKeyCommand>
    {
        public UpdatePublicKeyCommandValidator()
        {
            RuleFor(x => x.PublicKey).NotEmpty();
        }
    }
}