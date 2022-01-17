using System;
using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiCommands.KeyExchange;

public record CreateKeyExchangeResponse : ResponseBase
{
    public Guid RequestId { get; init; }
}