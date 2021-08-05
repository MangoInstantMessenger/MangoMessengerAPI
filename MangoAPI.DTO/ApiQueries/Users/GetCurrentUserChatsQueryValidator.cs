using System;
using FluentValidation;
using MangoAPI.DTO.ApiQueries.Chats;

namespace MangoAPI.DTO.ApiQueries.Users
{
    public class GetCurrentUserChatsQueryValidator : AbstractValidator<GetCurrentUserChatsQuery>
    {
        public GetCurrentUserChatsQueryValidator()
        {
            RuleFor(x => x.UserId)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .Length(2, 300);
            
            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("GetCurrentUserChatsQueryValidator: User Id cannot be parsed");
        }
    }
}