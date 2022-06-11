using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;

public class CngCreateKeyExchangeRequestCommandValidator : AbstractValidator<CngCreateKeyExchangeRequestCommand>
{
    public CngCreateKeyExchangeRequestCommandValidator()
    {
        RuleFor(x => x.SenderId).NotEmpty();
        RuleFor(x => x.ReceiverId).NotEmpty();
        RuleFor(x => x.SenderPublicKey).NotEmpty();
    }
}