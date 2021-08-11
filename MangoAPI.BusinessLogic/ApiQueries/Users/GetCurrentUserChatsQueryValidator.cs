using System;
using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.Users
{
    public class GetCurrentUserChatsQueryValidator : AbstractValidator<GetCurrentUserChatsQuery>
    {
        public GetCurrentUserChatsQueryValidator()
        {
            RuleFor(x => x.UserId)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(2, 300);

            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("GetCurrentUserChatsQueryValidator: User Id cannot be parsed");
        }
    }
}