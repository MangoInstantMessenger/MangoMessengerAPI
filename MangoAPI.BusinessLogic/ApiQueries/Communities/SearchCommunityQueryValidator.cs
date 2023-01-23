using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.Communities;

public class SearchCommunityQueryValidator : AbstractValidator<SearchCommunityQuery>
{
    public SearchCommunityQueryValidator()
    {
        _ = RuleFor(x => x.DisplayName).NotEmpty().Length(1, 30);
        _ = RuleFor(x => x.UserId).NotEmpty();
    }
}