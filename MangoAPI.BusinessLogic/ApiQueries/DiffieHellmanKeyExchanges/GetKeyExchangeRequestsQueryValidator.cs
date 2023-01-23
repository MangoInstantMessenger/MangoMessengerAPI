using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;

public class GetKeyExchangeRequestsQueryValidator : AbstractValidator<GetKeyExchangeRequestsQuery>
{
    public GetKeyExchangeRequestsQueryValidator()
    {
        _ = RuleFor(x => x.UserId).NotEmpty();
    }
}