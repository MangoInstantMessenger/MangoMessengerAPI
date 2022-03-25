using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;

public record OpenSslGetKeyExchangeRequestByIdQuery : IRequest<Result<OpenSslGetKeyExchangeRequestByIdResponse>>
{
    public Guid UserId { get; set; }
    public Guid KeyExchangeRequestId { get; set; }
}