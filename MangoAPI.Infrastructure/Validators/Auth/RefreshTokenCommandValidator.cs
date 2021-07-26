using FluentValidation;
using MangoAPI.DTO.ApiCommands.Auth;

namespace MangoAPI.Infrastructure.Validators.Auth
{
    public class RefreshTokenCommandValidator : AbstractValidator<RefreshTokenCommand>
    {
        public RefreshTokenCommandValidator()
        {
            RuleFor(x => x.RefreshTokenId).NotNull().NotEmpty();
        }
    }
}