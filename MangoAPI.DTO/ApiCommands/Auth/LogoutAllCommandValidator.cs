using System;
using FluentValidation;

namespace MangoAPI.DTO.ApiCommands.Auth
{
    public class LogoutAllCommandValidator : AbstractValidator<LogoutAllCommand>
    {
        public LogoutAllCommandValidator()
        {
            RuleFor(x => x.RefreshTokenId)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .Length(2, 300);
            
            RuleFor(x => x.RefreshTokenId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("LogoutAllCommand: Refresh Token Id cannot be parsed.");
            
            RuleFor(x => x.UserId)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .Length(2, 300);
            
            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("LogoutAllCommand: User Id cannot be parsed.");
        }
    }
}