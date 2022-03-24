using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;

public record OpenSslGetDhParametersQuery : IRequest<Result<OpenSslGetDhParametersResponse>>;