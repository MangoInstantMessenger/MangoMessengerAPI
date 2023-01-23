using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.DiffieHellmanKeyExchanges;

public class ConfirmKeyExchangeCommandValidator : AbstractValidator<ConfirmKeyExchangeCommand>
{
    public ConfirmKeyExchangeCommandValidator()
    {
        _ = RuleFor(x => x.UserId).NotEmpty();
        _ = RuleFor(x => x.RequestId).NotEmpty();
        _ = RuleFor(x => x.ReceiverPublicKey).NotEmpty();
    }
}