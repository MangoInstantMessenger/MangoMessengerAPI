using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiCommands.KeyExchange;

public class
    OpenSslCreateDiffieHellmanParameterCommandValidator : AbstractValidator<OpenSslCreateDiffieHellmanParameterCommand>
{
    public OpenSslCreateDiffieHellmanParameterCommandValidator()
    {
        RuleFor(x => x.UserId).NotEmpty();
        RuleFor(x => x.DiffieHellmanParameter).NotEmpty();
    }
}