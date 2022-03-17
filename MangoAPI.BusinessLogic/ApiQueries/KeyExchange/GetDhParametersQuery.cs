using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.KeyExchange;

public record GetDhParametersQuery : IRequest<Result<GetDhParametersResponse>>;