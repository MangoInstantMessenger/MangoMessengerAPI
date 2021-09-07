using System;
using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.Messages
{
    public class GetMessagesQueryValidator : AbstractValidator<GetMessagesQuery>
    {
        public GetMessagesQueryValidator()
        {
            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("GetMessagesQuery: User Id cannot be parsed.");

            RuleFor(x => x.ChatId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("GetMessagesQuery: Chat Id cannot be parsed.");
        }
    }
}
