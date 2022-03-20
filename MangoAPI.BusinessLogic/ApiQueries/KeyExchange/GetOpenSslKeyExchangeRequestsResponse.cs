﻿using System.Collections.Generic;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiQueries.KeyExchange;

public record GetOpenSslKeyExchangeRequestsResponse : ResponseBase
{
    public List<OpenSslKeyExchangeRequest> OpenSslKeyExchangeRequests { get; init; }
}