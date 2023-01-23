using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.DiffieHellmanKeyExchanges;

public class DeclineKeyExchangeCommandValidator : AbstractValidator<DeclineKeyExchangeCommand>
{
    public DeclineKeyExchangeCommandValidator()
    {
        _ = RuleFor(x => x.RequestId).NotEmpty();
        _ = RuleFor(x => x.UserId).NotEmpty();
    }
}