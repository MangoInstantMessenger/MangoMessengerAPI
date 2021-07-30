using System;
using FluentValidation;

namespace MangoAPI.DTO.ApiCommands.Auth
{
    public class VerifyEmailCommandValidator : AbstractValidator<VerifyEmailCommand>
    {
        public VerifyEmailCommandValidator()
        {
            RuleFor(x => x.Email).NotNull().NotEmpty();
            
            RuleFor(x => x.UserId).NotNull().NotEmpty();
            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("Verify  email: User Id cannot be parsed.");
        }
    }
}