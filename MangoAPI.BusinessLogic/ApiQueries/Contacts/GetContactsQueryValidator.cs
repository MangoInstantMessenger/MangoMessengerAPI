namespace MangoAPI.BusinessLogic.ApiQueries.Contacts
{
    using System;
    using FluentValidation;

    public class GetContactsQueryValidator : AbstractValidator<GetContactsQuery>
    {
        public GetContactsQueryValidator()
        {
            RuleFor(x => x.UserId)
                .Must(x => Guid.TryParse(x, out _))
                .WithMessage("SearchChatsQueryValidator: User Id cannot be parsed.");
        }
    }
}
