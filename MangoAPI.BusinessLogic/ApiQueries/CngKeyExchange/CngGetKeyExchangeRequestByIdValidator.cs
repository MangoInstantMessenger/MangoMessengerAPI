using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.CngKeyExchange;

public class CngKeyGetKeyExchangeRequestByIdValidator : AbstractValidator<CngGetKeyExchangeRequestByIdQuery>
{
    public CngKeyGetKeyExchangeRequestByIdValidator()
    {
        RuleFor(x => x.RequestId).NotEmpty();
        RuleFor(x => x.UserId).NotEmpty();
    }
}