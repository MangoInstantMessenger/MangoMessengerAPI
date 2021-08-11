using System;
using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.Messages
{
    public class GetMessagesQueryValidator : AbstractValidator<GetMessagesQuery>
    {
        public GetMessagesQueryValidator()
        {
            RuleFor(x => x.UserId)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(2, 300);

            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("GetMessagesQuery: User Id cannot be parsed.");

            RuleFor(x => x.ChatId)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .Length(2, 300);

            RuleFor(x => x.ChatId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("GetMessagesQuery: User Id cannot be parsed.");
        }
    }
}