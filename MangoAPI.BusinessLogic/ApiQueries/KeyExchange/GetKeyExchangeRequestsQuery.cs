using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.KeyExchange;

public record GetKeyExchangeRequestsQuery : IRequest<Result<GetKeyExchangeResponse>>
{
    public Guid UserId { get; init; }
}