using FluentValidation;
using MangoAPI.DTO.ApiCommands.Auth;

namespace MangoAPI.Infrastructure.Validators.Auth
{
    public class LogoutCommandValidator : AbstractValidator<LogoutCommand>
    {
        public LogoutCommandValidator()
        {
            RuleFor(x => x.RefreshTokenId).NotNull().NotEmpty();
        }
    }
}