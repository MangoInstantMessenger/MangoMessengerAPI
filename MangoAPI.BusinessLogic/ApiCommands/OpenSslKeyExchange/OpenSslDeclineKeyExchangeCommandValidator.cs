using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.OpenSslKeyExchange;

public class OpenSslDeclineKeyExchangeCommandValidator : AbstractValidator<OpenSslDeclineKeyExchangeCommand>
{
    public OpenSslDeclineKeyExchangeCommandValidator()
    {
        RuleFor(x => x.RequestId).NotEmpty();
        RuleFor(x => x.UserId).NotEmpty();
    }
}