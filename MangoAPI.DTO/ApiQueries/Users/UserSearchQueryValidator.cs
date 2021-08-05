using System;
using FluentValidation;

namespace MangoAPI.DTO.ApiQueries.Users
{
    public class UserSearchQueryValidator : AbstractValidator<UserSearchQuery>
    {
        public UserSearchQueryValidator()
        {
            RuleFor(x => x.DisplayName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(2, 300);

            RuleFor(x => x.DisplayName).Must(x => Guid.TryParse(x, out _))
                .WithMessage("UserSearchQuery: User Id cannot be parsed.");
        }
    }
}