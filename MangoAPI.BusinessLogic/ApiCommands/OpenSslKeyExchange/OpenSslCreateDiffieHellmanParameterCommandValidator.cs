using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.OpenSslKeyExchange;

public class
    OpenSslCreateDiffieHellmanParameterCommandValidator : AbstractValidator<OpenSslCreateDiffieHellmanParameterCommand>
{
    public OpenSslCreateDiffieHellmanParameterCommandValidator()
    {
        RuleFor(x => x.UserId).NotEmpty();
        RuleFor(x => x.DiffieHellmanParameter).NotEmpty();
    }
}