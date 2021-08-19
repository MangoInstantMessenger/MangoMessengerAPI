namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    using System;
    using FluentValidation;

    public class LogoutAllCommandValidator : AbstractValidator<LogoutAllCommand>
    {
        public LogoutAllCommandValidator()
        {
            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("LogoutAllCommand: User Id cannot be parsed.");
        }
    }
}
