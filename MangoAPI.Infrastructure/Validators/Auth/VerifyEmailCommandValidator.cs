using FluentValidation;
using MangoAPI.DTO.ApiCommands.Auth;

namespace MangoAPI.Infrastructure.Validators.Auth
{
    public class VerifyEmailCommandValidator : AbstractValidator<VerifyEmailCommand>
    {
        public VerifyEmailCommandValidator()
        {
            RuleFor(x => x.Email).NotNull().NotEmpty();
            RuleFor(x => x.UserId).NotNull().NotEmpty();
        }
    }
}