using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.PublicKeys;

public class GetPublicKeysQueryValidator : AbstractValidator<GetPublicKeysQuery>
{
    public GetPublicKeysQueryValidator()
    {
        RuleFor(x => x.UserId).NotEmpty();
    }
}