using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public class ChangePasswordCommandValidator : AbstractValidator<ChangePasswordCommand>
    {
        public ChangePasswordCommandValidator()
        {
            RuleFor(x => x.CurrentPassword)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 50);

            RuleFor(x => x.NewPassword)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 50);
        }
    }
}
