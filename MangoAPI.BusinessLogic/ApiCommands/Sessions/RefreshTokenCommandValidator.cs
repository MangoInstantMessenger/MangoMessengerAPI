using System;
using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    public class RefreshTokenCommandValidator : AbstractValidator<RefreshSessionCommand>
    {
        public RefreshTokenCommandValidator()
        {
            RuleFor(x => x.RefreshToken).Must(x => Guid.TryParse(x, out _))
                .WithMessage("RefreshTokenCommand: Refresh Token Id cannot be parsed.");
        }
    }
}