using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.KeyExchange;

public class OpenSslConfirmKeyExchangeCommandValidator : AbstractValidator<OpenSslConfirmKeyExchangeCommand>
{
    public OpenSslConfirmKeyExchangeCommandValidator()
    {
        RuleFor(x => x.UserId).NotEmpty();
        RuleFor(x => x.RequestId).NotEmpty();
        RuleFor(x => x.Confirmed).Equal(true);
        RuleFor(x => x.ReceiverPublicKey).NotEmpty();
    }
}