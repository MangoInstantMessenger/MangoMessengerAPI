namespace MangoAPI.BusinessLogic.ApiQueries.Users
{
    using FluentValidation;

    public class UserSearchCommandValidator : AbstractValidator<SearchUserByDisplayNameQuery>
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
