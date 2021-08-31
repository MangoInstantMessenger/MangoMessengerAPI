using System;
using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    public class RefreshSessionCommandValidator : AbstractValidator<RefreshSessionCommand>
    {
        public RefreshSessionCommandValidator()
        {
            RuleFor(x => x.RefreshToken).Must(x => Guid.TryParse(x, out _))
                .WithMessage("RefreshSessionCommand: Refresh Token Id cannot be parsed.");
        }
    }
}
