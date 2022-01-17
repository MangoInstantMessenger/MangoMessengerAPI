using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.KeyExchange;

public class CreateKeyExchangeRequestCommandValidator : AbstractValidator<CreateKeyExchangeRequestCommand>
{
    public CreateKeyExchangeRequestCommandValidator()
    {
        RuleFor(x => x.UserId).NotEmpty();
        RuleFor(x => x.RequestedUserId).NotEmpty();
        RuleFor(x => x.PublicKey).NotEmpty();
    }
}