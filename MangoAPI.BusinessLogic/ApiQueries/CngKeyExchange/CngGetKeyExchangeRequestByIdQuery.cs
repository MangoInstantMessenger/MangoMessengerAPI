using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.CngKeyExchange;

public class CngGetKeyExchangeRequestByIdQuery : IRequest<Result<CngGetKeyExchangeRequestByIdResponse>>
{
    public Guid UserId { get; init; }
    public Guid RequestId { get; init; }
}