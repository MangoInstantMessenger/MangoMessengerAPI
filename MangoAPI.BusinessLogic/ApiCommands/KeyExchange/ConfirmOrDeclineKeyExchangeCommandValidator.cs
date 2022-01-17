using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.KeyExchange;

public class ConfirmOrDeclineKeyExchangeCommandValidator : AbstractValidator<ConfirmOrDeclineKeyExchangeCommand>
{
    public ConfirmOrDeclineKeyExchangeCommandValidator()
    {
        RuleFor(x => x.PublicKey).NotEmpty();
        RuleFor(x => x.RequestId).NotEmpty();
        RuleFor(x => x.UserId).NotEmpty();
    }
}