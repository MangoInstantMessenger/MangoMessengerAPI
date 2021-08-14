using System;
using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.Chats
{
    public class SearchChatsQueryValidator : AbstractValidator<SearchChatsQuery>
    {
        public SearchChatsQueryValidator()
        {
            RuleFor(x => x.DisplayName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 300);
            
            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("SearchChatsQueryValidator: User Id cannot be parsed.");
        }
    }
}