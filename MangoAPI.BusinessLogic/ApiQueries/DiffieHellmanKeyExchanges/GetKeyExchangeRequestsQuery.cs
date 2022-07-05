using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;

public record GetKeyExchangeRequestsQuery(Guid UserId)
    : IRequest<Result<GetKeyExchangeRequestsResponse>>;
