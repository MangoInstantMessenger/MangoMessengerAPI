using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.DiffieHellmanKeyExchanges;

public class ConfirmKeyExchangeCommandValidator : AbstractValidator<ConfirmKeyExchangeCommand>
{
    public ConfirmKeyExchangeCommandValidator()
    {
        RuleFor(x => x.UserId).NotEmpty();
        RuleFor(x => x.RequestId).NotEmpty();
        RuleFor(x => x.ReceiverPublicKey).NotEmpty();
    }
}