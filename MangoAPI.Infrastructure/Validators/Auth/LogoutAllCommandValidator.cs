using System;
using FluentValidation;
using MangoAPI.DTO.ApiCommands.Auth;

namespace MangoAPI.Infrastructure.Validators.Auth
{
    public class LogoutAllCommandValidator : AbstractValidator<LogoutAllCommand>
    {
        public LogoutAllCommandValidator()
        {
            RuleFor(x => x.RefreshTokenId).NotNull().NotEmpty();
            RuleFor(x => x.RefreshTokenId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("LogoutAllCommand: Refresh Token Id cannot be parsed.");
            
            RuleFor(x => x.UserId).NotNull().NotEmpty();
            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("LogoutAllCommand: User Id cannot be parsed.");
        }
    }
}