using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.Messages
{
    public class SearchChatMessagesValidator : AbstractValidator<SearchChatMessagesQuery>
    {
        public SearchChatMessagesValidator()
        {
            RuleFor(x => x.MessageText)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(1, 300);
        }
    }
}