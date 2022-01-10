using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.Contacts
{
    public class SearchContactQueryValidator : AbstractValidator<SearchContactQuery>
    {
        public SearchContactQueryValidator()
        {
            RuleFor(x => x.SearchQuery).NotEmpty().Length(1, 30);
            RuleFor(x => x.UserId).NotEmpty();
        }
    }
}