using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;

public class CngConfirmOrDeclineKeyExchangeCommandValidator : AbstractValidator<CngConfirmKeyExchangeCommand>
{
    public CngConfirmOrDeclineKeyExchangeCommandValidator()
    {
        RuleFor(x => x.ReceiverPublicKey).NotEmpty();
        RuleFor(x => x.RequestId).NotEmpty();
        RuleFor(x => x.UserId).NotEmpty();
    }
}