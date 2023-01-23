using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.DiffieHellmanKeyExchanges;

public class
    CreateDiffieHellmanParameterCommandValidator : AbstractValidator<CreateDiffieHellmanParameterCommand>
{
    public CreateDiffieHellmanParameterCommandValidator()
    {
        _ = RuleFor(x => x.UserId).NotEmpty();
        _ = RuleFor(x => x.DiffieHellmanParameter).NotEmpty();
    }
}