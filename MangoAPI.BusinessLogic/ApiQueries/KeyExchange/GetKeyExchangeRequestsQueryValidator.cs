using FluentValidation;

namespace MangoAPI.BusinessLogic.ApiQueries.KeyExchange
{
    public class GetKeyExchangeRequestsQueryValidator : AbstractValidator<GetKeyExchangeRequestsQuery>
    {
        public GetKeyExchangeRequestsQueryValidator()
        {
            RuleFor(x => x.UserId).NotEmpty();
        }
    }
}