using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.PublicKeys;

public class CngGetPublicKeysQueryValidator : AbstractValidator<CngGetPublicKeysQuery>
{
    public CngGetPublicKeysQueryValidator()
    {
        RuleFor(x => x.UserId).NotEmpty();
    }
}