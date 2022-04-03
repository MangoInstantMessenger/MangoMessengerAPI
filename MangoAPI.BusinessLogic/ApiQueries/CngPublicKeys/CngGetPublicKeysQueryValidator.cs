using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.CngPublicKeys;

public class CngGetPublicKeysQueryValidator : AbstractValidator<CngGetPublicKeysQuery>
{
    public CngGetPublicKeysQueryValidator()
    {
        RuleFor(x => x.UserId).NotEmpty();
    }
}