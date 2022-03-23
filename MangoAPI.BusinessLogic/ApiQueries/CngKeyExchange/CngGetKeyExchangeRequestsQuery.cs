using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.CngKeyExchange;

public record CngGetKeyExchangeRequestsQuery : IRequest<Result<CngGetKeyExchangeResponse>>
{
    public Guid UserId { get; init; }
}