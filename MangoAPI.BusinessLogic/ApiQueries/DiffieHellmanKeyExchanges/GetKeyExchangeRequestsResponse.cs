using System.Collections.Generic;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;

public record GetKeyExchangeRequestsResponse : ResponseBase
{
    public List<OpenSslKeyExchangeRequest> OpenSslKeyExchangeRequests { get; init; }
}