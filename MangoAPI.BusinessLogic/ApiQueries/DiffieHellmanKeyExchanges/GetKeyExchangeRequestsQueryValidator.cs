using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;

public class GetKeyExchangeRequestsQueryValidator : AbstractValidator<GetKeyExchangeRequestsQuery>
{
    public GetKeyExchangeRequestsQueryValidator()
    {
        RuleFor(x => x.UserId).NotEmpty();
    }
}