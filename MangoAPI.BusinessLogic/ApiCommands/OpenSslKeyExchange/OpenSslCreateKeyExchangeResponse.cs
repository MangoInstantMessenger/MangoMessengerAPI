using System;
using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiCommands.OpenSslKeyExchange;

public record OpenSslCreateKeyExchangeResponse : ResponseBase
{
    public Guid RequestId { get; init; }
}