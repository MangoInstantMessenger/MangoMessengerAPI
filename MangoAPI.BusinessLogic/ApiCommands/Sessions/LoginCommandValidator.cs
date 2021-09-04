using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    public class LoginCommandValidator : AbstractValidator<LoginCommand>
    {
        public LoginCommandValidator()
        {
            RuleFor(x => x.EmailOrPhone)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 300);

            RuleFor(x => x.Password)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 300);
        }
    }
}