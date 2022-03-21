using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.KeyExchange;

public class OpenSslGetKeyExchangeRequestsQueryValidator : AbstractValidator<OpenSslGetKeyExchangeRequestsQuery>
{
    public OpenSslGetKeyExchangeRequestsQueryValidator()
    {
        RuleFor(x => x.UserId).NotEmpty();
    }
}