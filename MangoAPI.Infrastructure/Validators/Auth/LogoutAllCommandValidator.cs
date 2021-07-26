using FluentValidation;
using MangoAPI.DTO.ApiCommands.Auth;

namespace MangoAPI.Infrastructure.Validators.Auth
{
    public class LogoutAllCommandValidator : AbstractValidator<LogoutAllCommand>
    {
        public LogoutAllCommandValidator()
        {
            RuleFor(x => x.RefreshTokenId).NotNull().NotEmpty();
            RuleFor(x => x.UserId).NotNull().NotEmpty();
        }
    }
}