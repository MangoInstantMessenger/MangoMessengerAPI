using System;
using MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.CngKeyExchange;

public record CngGetKeyExchangeRequestsQuery(Guid UserId) 
    : IRequest<Result<OpenSslGetKeyExchangeRequestsResponse>>;