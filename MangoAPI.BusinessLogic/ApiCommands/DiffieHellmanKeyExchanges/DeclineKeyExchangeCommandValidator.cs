using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.DiffieHellmanKeyExchanges;

public class DeclineKeyExchangeCommandValidator : AbstractValidator<DeclineKeyExchangeCommand>
{
    public DeclineKeyExchangeCommandValidator()
    {
        RuleFor(x => x.RequestId).NotEmpty();
        RuleFor(x => x.UserId).NotEmpty();
    }
}