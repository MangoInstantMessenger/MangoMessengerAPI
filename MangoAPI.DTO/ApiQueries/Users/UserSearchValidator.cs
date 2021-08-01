using System;
using FluentValidation;

namespace MangoAPI.DTO.ApiQueries.Users
{
    public class UserSearchValidator : AbstractValidator<UserSearchQuery>
    {
        public UserSearchValidator()
        {
            RuleFor(x => x.DisplayName).NotEmpty().NotEmpty();
            RuleFor(x => x.DisplayName).Must(x => Guid.TryParse(x, out _))
                .WithMessage("GetUserQuery: User Id cannot be parsed.");
        }
    }
}