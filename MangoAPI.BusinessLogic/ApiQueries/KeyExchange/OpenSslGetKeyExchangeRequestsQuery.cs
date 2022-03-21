using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.KeyExchange;

public record OpenSslGetKeyExchangeRequestsQuery : IRequest<Result<OpenSslGetKeyExchangeRequestsResponse>>
{
    public Guid UserId { get; init; }
}