using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.Messages;

public class SearchChatMessageQueryValidator : AbstractValidator<SearchChatMessagesQuery>
{
    public SearchChatMessageQueryValidator()
    {
        RuleFor(x => x.ChatId).NotEmpty();
        RuleFor(x => x.MessageText).NotEmpty().Length(1, 30);
        RuleFor(x => x.UserId).NotEmpty();
    }
}