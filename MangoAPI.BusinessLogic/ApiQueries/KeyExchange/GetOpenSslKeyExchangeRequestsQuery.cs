using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.KeyExchange;

public record GetOpenSslKeyExchangeRequestsQuery : IRequest<Result<GetOpenSslKeyExchangeRequestsResponse>>
{
    public Guid UserId { get; init; }
}