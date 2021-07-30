using System;
using FluentValidation;
using MangoAPI.DTO.ApiQueries.Chats;

namespace MangoAPI.DTO.ApiCommands.Chats
{
    public class GetCurrentUserChatsQueryValidator : AbstractValidator<GetCurrentUserChatsQuery>
    {
        public GetCurrentUserChatsQueryValidator()
        {
            RuleFor(x => x.UserId).NotNull().NotEmpty();
            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("GetCurrentUserChatsQueryValidator: User Id cannot be parsed");
        }
    }
}