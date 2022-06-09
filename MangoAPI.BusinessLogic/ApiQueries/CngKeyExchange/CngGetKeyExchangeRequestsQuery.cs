using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.CngKeyExchange;

public record CngGetKeyExchangeRequestsQuery(Guid UserId) : IRequest<Result<CngGetKeyExchangeResponse>>;