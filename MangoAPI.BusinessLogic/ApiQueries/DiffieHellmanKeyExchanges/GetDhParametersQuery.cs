using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;

public record GetDhParametersQuery : IRequest<Result<GetDhParametersResponse>>;