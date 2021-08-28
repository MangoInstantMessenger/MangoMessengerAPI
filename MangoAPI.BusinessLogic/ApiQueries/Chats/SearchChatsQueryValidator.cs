namespace MangoAPI.BusinessLogic.ApiQueries.Chats
{
    using FluentValidation;
    using System;

    public class SearchChatsQueryValidator : AbstractValidator<SearchChatsQuery>
    {
        public SearchChatsQueryValidator()
        {
            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("SearchChatsQueryValidator: User Id cannot be parsed.");
        }
    }
}