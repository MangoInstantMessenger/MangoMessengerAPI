using FluentValidation;

namespace MangoAPI.DTO.ApiCommands.Auth
{
    public class LogoutCommandValidator : AbstractValidator<LogoutCommand>
    {
        public LogoutCommandValidator()
        {
            RuleFor(x => x.RefreshTokenId)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(2, 300);
        }
    }
}