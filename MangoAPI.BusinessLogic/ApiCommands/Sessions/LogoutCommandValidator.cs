namespace MangoAPI.BusinessLogic.ApiCommands.Sessions
{
    using FluentValidation;

    public class LogoutCommandValidator : AbstractValidator<LogoutCommand>
    {
        public LogoutCommandValidator()
        {
            RuleFor(x => x.RefreshToken)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 300);
        }
    }
}
