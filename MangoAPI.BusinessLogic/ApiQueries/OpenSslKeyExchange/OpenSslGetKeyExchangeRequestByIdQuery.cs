using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;

public record OpenSslGetKeyExchangeRequestByIdQuery(Guid UserId, Guid KeyExchangeRequestId) 
    : IRequest<Result<OpenSslGetKeyExchangeRequestByIdResponse>>;