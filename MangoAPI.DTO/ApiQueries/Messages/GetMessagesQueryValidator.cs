using System;
using FluentValidation;

namespace MangoAPI.DTO.ApiQueries.Messages
{
    public class GetMessagesQueryValidator : AbstractValidator<GetMessagesQuery>
    {
        public GetMessagesQueryValidator()
        {
            RuleFor(x => x.UserId).NotEmpty().NotEmpty();
            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("GetMessagesQuery: User Id cannot be parsed.");
            
            RuleFor(x => x.ChatId).NotEmpty().NotEmpty();
            RuleFor(x => x.ChatId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("GetMessagesQuery: User Id cannot be parsed.");
        }
    }
}