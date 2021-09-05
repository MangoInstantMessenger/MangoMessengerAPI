using System;
using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public class UpdatePublicKeyCommandValidator : AbstractValidator<UpdatePublicKeyCommand>
    {
        public UpdatePublicKeyCommandValidator()
        {
            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("UpdatePublicKeyCommand: User Id cannot be parsed.");

            RuleFor(x => x.PublicKey).NotEmpty();
        }
    }
}