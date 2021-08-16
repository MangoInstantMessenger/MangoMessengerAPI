using System;
using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    public class LogoutAllCommandValidator : AbstractValidator<LogoutAllCommand>
    {
        public LogoutAllCommandValidator()
        {
            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("LogoutAllCommand: User Id cannot be parsed.");
        }
    }
}