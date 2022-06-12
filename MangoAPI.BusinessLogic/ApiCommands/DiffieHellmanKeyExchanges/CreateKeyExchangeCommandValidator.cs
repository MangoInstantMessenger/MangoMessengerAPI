using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.DiffieHellmanKeyExchanges;

public class CreateKeyExchangeCommandValidator : AbstractValidator<CreateKeyExchangeCommand>
{
    public CreateKeyExchangeCommandValidator()
    {
        RuleFor(x => x.ReceiverId).NotEmpty();
        RuleFor(x => x.SenderId).NotEmpty();
        RuleFor(x => x.SenderPublicKey).NotEmpty();
    }
}