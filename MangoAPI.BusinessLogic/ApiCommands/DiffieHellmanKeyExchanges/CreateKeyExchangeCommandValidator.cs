using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.DiffieHellmanKeyExchanges;

public class CreateKeyExchangeCommandValidator : AbstractValidator<CreateKeyExchangeCommand>
{
    public CreateKeyExchangeCommandValidator()
    {
        _ = RuleFor(x => x.ReceiverId).NotEmpty();
        _ = RuleFor(x => x.SenderId).NotEmpty();
        _ = RuleFor(x => x.SenderPublicKey).NotEmpty();
        _ = RuleFor(x => x.KeyExchangeType).IsInEnum();
    }
}