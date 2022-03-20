using System;
using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiCommands.KeyExchange;

public record OpenSslCreateKeyExchangeResponse : ResponseBase
{
    public Guid RequestId { get; init; }
}