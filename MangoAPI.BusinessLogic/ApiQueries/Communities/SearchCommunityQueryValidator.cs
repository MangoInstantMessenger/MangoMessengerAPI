using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.Communities
{
    public class SearchCommunityQueryValidator : AbstractValidator<SearchCommunityQuery>
    {
        public SearchCommunityQueryValidator()
        {
            RuleFor(x => x.DisplayName).NotEmpty().Length(1, 30);
            RuleFor(x => x.UserId).NotEmpty();
        }
    }
}