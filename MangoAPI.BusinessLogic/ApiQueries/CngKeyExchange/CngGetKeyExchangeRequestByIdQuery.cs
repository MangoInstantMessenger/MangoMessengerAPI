using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.CngKeyExchange;

public record CngGetKeyExchangeRequestByIdQuery(Guid UserId, Guid RequestId) 
    : IRequest<Result<CngGetKeyExchangeRequestByIdResponse>>;