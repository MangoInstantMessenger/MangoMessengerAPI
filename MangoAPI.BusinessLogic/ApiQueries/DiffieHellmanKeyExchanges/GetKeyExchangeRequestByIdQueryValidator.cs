using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;

public class GetKeyExchangeRequestByIdQueryValidator : AbstractValidator<GetKeyExchangeRequestByIdQuery>
{
    public GetKeyExchangeRequestByIdQueryValidator()
    {
        _ = RuleFor(x => x.UserId).NotEmpty();
        _ = RuleFor(x => x.KeyExchangeRequestId).NotEmpty();
    }
}