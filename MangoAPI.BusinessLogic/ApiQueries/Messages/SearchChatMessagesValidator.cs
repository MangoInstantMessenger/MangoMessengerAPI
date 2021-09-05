using System;
using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.Messages
{
    public class SearchChatMessagesValidator : AbstractValidator<SearchChatMessagesQuery>
    {
        public SearchChatMessagesValidator()
        {
            RuleFor(x => x.UserId)
                .Must(x => Guid.TryParse(x, out _))
                .WithMessage("SearchChatMessagesQuery: User Id cannot be parsed.");

            RuleFor(x => x.ChatId)
                .Must(x => Guid.TryParse(x, out _))
                .WithMessage("SearchChatMessagesQuery: Chat Id cannot be parsed.");
            
            RuleFor(x => x.MessageText)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 300);
        }
    }
}