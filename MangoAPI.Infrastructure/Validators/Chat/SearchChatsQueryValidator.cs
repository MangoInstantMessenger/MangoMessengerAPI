using System;
using FluentValidation;
using MangoAPI.DTO.ApiQueries.Chats;

namespace MangoAPI.Infrastructure.Validators.Chat
{
    public class SearchChatsQueryValidator : AbstractValidator<SearchChatsQuery>
    {
        public SearchChatsQueryValidator()
        {
            RuleFor(x => x.DisplayName).NotNull().NotEmpty();
            
            RuleFor(x => x.UserId).NotNull().NotEmpty();
            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("SearchChatsQueryValidator: User Id cannot be parsed.");
        }
    }
}