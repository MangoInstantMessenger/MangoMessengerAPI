using System;

namespace MangoAPI.BusinessLogic.ApiCommands.KeyExchange;

public record CreateKeyExchangeRequest
{
    public Guid RequestedUserId { get; init; }
    public string PublicKey { get; init; }
}