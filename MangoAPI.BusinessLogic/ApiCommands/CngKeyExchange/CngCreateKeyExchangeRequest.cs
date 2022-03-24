using System;

namespace MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;

public record CngCreateKeyExchangeRequest
{
    public Guid RequestedUserId { get; init; }
    public string PublicKey { get; init; }
}