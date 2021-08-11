using System;
using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.Users
{
    public class GetUserQueryValidator : AbstractValidator<GetUserQuery>
    {
        public GetUserQueryValidator()
        {
            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("GetUserQuery: User Id cannot be parsed.");
        }
    }
}