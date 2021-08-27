namespace MangoAPI.BusinessLogic.ApiQueries.Chats
{
    using System;
    using FluentValidation;

    public class GetCurrentUserChatsQueryValidator : AbstractValidator<GetCurrentUserChatsQuery>
    {
        public GetCurrentUserChatsQueryValidator()
        {
            RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out _))
                .WithMessage("GetCurrentUserChatsQueryValidator: User Id cannot be parsed");
        }
    }
}
