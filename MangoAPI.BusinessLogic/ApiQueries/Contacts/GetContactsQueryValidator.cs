using System;
using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.Contacts
{
    public class GetContactsQueryValidator : AbstractValidator<GetContactsQuery>
    {
        public GetContactsQueryValidator()
        {
            RuleFor(x => x.UserId)
                .Cascade(CascadeMode.Stop)
                .Length(36);
            
            RuleFor(x => x.UserId)
                .Must(x => Guid.TryParse(x, out _));
            
        }
    }
}