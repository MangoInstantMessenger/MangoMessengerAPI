using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;

public class OpenSslGetKeyExchangeRequestsQueryValidator : AbstractValidator<OpenSslGetKeyExchangeRequestsQuery>
{
    public OpenSslGetKeyExchangeRequestsQueryValidator()
    {
        RuleFor(x => x.UserId).NotEmpty();
    }
}