using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public class UserSearchCommandValidator : AbstractValidator<UserSearchCommand>
    {
        public UserSearchCommandValidator()
        {
            RuleFor(x => x.DisplayName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 300);
        }
    }
}