using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.CngKeyExchange;

public class CngGetKeyExchangeRequestsQueryValidator : AbstractValidator<CngGetKeyExchangeRequestsQuery>
{
    public CngGetKeyExchangeRequestsQueryValidator()
    {
        RuleFor(x => x.UserId).NotEmpty();
    }
}