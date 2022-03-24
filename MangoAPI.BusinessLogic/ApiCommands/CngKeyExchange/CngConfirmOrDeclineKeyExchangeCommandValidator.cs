using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;

public class CngConfirmOrDeclineKeyExchangeCommandValidator : AbstractValidator<CngConfirmOrDeclineKeyExchangeCommand>
{
    public CngConfirmOrDeclineKeyExchangeCommandValidator()
    {
        RuleFor(x => x.PublicKey).NotEmpty();
        RuleFor(x => x.RequestId).NotEmpty();
        RuleFor(x => x.UserId).NotEmpty();
    }
}