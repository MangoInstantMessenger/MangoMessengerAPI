using System.Collections.Generic;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiQueries.KeyExchange
{
    public record GetKeyExchangeResponse : ResponseBase
    {
        public List<KeyExchangeRequest> KeyExchangeRequests { get; init; }
    }
}