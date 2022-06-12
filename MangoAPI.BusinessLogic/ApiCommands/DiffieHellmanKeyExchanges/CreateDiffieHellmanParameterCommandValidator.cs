using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.DiffieHellmanKeyExchanges;

public class
    CreateDiffieHellmanParameterCommandValidator : AbstractValidator<CreateDiffieHellmanParameterCommand>
{
    public CreateDiffieHellmanParameterCommandValidator()
    {
        RuleFor(x => x.UserId).NotEmpty();
        RuleFor(x => x.DiffieHellmanParameter).NotEmpty();
    }
}