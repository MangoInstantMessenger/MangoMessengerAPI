using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.Contacts;

public class SearchContactQueryValidator : AbstractValidator<SearchContactQuery>
{
    public SearchContactQueryValidator()
    {
        _ = RuleFor(x => x.SearchQuery).NotEmpty().Length(1, 30);
        _ = RuleFor(x => x.UserId).NotEmpty();
    }
}