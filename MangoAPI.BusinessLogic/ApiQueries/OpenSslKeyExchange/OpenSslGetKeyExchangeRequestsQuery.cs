using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;

public record OpenSslGetKeyExchangeRequestsQuery(Guid UserId) : IRequest<Result<OpenSslGetKeyExchangeRequestsResponse>>;