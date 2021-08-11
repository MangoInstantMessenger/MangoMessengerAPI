using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.Users
{
    public class UserSearchQueryValidator : AbstractValidator<UserSearchQuery>
    {
        public UserSearchQueryValidator()
        {
            RuleFor(x => x.DisplayName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(2, 300);
        }
    }
}