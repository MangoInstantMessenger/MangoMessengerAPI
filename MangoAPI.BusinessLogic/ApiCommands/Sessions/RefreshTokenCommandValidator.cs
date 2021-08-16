using System;
using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Auth
{
    public class RefreshTokenCommandValidator : AbstractValidator<RefreshSessionCommand>
    {
        public RefreshTokenCommandValidator()
        {
            RuleFor(x => x.SessionId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("RefreshTokenCommand: Refresh Token Id cannot be parsed.");
        }
    }
}