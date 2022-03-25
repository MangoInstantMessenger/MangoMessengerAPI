using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;

public record OpenSslGetKeyExchangeRequestByIdQuery : IRequest<Result<OpenSslGetKeyExchangeRequestByIdResponse>>
{
    public Guid UserId { get; init; }
    public Guid KeyExchangeRequestId { get; init; }
}