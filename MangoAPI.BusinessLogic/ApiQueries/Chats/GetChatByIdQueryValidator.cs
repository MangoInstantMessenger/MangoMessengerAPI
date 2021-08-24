using System;
using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.Chats
{
    public class GetChatByIdQueryValidator : AbstractValidator<GetChatByIdQuery>
    {
        public GetChatByIdQueryValidator()
        {
            RuleFor(x => x.UserId)
                .Must(x => Guid.TryParse(x, out _))
                .WithMessage("Get Chat By Id: User id can not be parsed");
            
            RuleFor(x => x.ChatId)
                .Must(x => Guid.TryParse(x, out _))
                .WithMessage("Get Chat By Id: Chat id can not be parsed");
        }
    }
}