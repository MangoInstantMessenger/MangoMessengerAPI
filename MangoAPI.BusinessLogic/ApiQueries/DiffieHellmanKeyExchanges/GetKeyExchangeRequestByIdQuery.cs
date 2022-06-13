using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;

public record GetKeyExchangeRequestByIdQuery(Guid UserId, Guid KeyExchangeRequestId)
    : IRequest<Result<GetKeyExchangeRequestByIdResponse>>;