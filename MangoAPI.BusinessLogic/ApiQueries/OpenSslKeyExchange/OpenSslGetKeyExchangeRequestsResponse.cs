using System.Collections.Generic;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;

public record OpenSslGetKeyExchangeRequestsResponse : ResponseBase
{
    public List<OpenSslKeyExchangeRequest> OpenSslKeyExchangeRequests { get; init; }
}