using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.KeyExchange;

public class OpenSslDeclineKeyExchangeCommandValidator : AbstractValidator<OpenSslDeclineKeyExchangeCommand>
{
    public OpenSslDeclineKeyExchangeCommandValidator()
    {
        RuleFor(x => x.RequestId).NotEmpty();
        RuleFor(x => x.UserId).NotEmpty();
    }
}