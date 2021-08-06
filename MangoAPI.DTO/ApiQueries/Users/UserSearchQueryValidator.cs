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
        }
    }
}