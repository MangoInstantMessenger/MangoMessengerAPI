using System;
using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.Users
{
    public class GetCurrentUserChatsQueryValidator : AbstractValidator<GetCurrentUserChatsQuery>
    {
        public GetCurrentUserChatsQueryValidator()
        {
            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("GetCurrentUserChatsQueryValidator: User Id cannot be parsed");
        }
    }
}