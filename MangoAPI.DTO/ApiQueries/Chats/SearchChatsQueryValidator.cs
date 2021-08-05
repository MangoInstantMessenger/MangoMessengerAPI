using System;
using FluentValidation;

namespace MangoAPI.DTO.ApiQueries.Chats
{
    public class SearchChatsQueryValidator : AbstractValidator<SearchChatsQuery>
    {
        public SearchChatsQueryValidator()
        {
            RuleFor(x => x.DisplayName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(2, 300);

            RuleFor(x => x.UserId)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(2, 300);

            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("SearchChatsQueryValidator: User Id cannot be parsed.");
        }
    }
}