using System;
using FluentValidation;
using MangoAPI.DTO.ApiCommands.Auth;

namespace MangoAPI.Infrastructure.Validators.Auth
{
    public class VerifyPhoneCommandValidator : AbstractValidator<VerifyPhoneCommand>
    {
        public VerifyPhoneCommandValidator()
        {
            RuleFor(x => x.UserId).NotNull().NotEmpty();
            
            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("Verify Phone code: User Id cannot be parsed.");
            
            RuleFor(x => x.ConfirmationCode).NotNull().NotEmpty();
        }
    }
}