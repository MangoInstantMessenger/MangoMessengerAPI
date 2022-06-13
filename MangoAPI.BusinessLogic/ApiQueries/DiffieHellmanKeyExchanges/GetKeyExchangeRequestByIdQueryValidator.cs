using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;

public class GetKeyExchangeRequestByIdQueryValidator : AbstractValidator<GetKeyExchangeRequestByIdQuery>
{
    public GetKeyExchangeRequestByIdQueryValidator()
    {
        RuleFor(x => x.UserId).NotEmpty();
        RuleFor(x => x.KeyExchangeRequestId).NotEmpty();
    }
}