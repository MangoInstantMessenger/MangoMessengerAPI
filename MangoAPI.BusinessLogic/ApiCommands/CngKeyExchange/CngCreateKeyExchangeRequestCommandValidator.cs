using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;

public class CngCreateKeyExchangeRequestCommandValidator : AbstractValidator<CngCreateKeyExchangeRequestCommand>
{
    public CngCreateKeyExchangeRequestCommandValidator()
    {
        RuleFor(x => x.UserId).NotEmpty();
        RuleFor(x => x.RequestedUserId).NotEmpty();
        RuleFor(x => x.PublicKey).NotEmpty();
    }
}