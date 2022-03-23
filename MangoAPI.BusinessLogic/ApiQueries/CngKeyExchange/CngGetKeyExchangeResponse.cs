using System.Collections.Generic;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiQueries.CngKeyExchange;

public record CngGetKeyExchangeResponse : ResponseBase
{
    public List<KeyExchangeRequest> KeyExchangeRequests { get; init; }
}