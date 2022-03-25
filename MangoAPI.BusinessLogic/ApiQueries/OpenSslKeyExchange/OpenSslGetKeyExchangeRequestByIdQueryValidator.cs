using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;

public class OpenSslGetKeyExchangeRequestByIdQueryValidator : AbstractValidator<OpenSslGetKeyExchangeRequestByIdQuery>
{
    public OpenSslGetKeyExchangeRequestByIdQueryValidator()
    {
        RuleFor(x => x.UserId).NotEmpty();
        RuleFor(x => x.KeyExchangeRequestId).NotEmpty();
    }
}