using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.Messages;

public class SearchChatMessageQueryValidator : AbstractValidator<SearchChatMessagesQuery>
{
    public SearchChatMessageQueryValidator()
    {
        _ = RuleFor(x => x.ChatId).NotEmpty();
        _ = RuleFor(x => x.MessageText).NotEmpty().Length(1, 30);
        _ = RuleFor(x => x.UserId).NotEmpty();
    }
}