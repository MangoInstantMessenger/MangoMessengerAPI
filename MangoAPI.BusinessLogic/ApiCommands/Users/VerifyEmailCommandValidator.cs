using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public class VerifyEmailCommandValidator : AbstractValidator<VerifyEmailCommand>
{
    public VerifyEmailCommandValidator()
    {
        RuleFor(x => x.Email)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .Length(1, 300);
    }
}