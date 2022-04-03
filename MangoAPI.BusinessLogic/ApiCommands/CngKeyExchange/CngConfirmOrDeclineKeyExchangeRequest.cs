using System;

namespace MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;

public record CngConfirmOrDeclineKeyExchangeRequest
{
    public Guid RequestId { get; init; }
    public bool Confirmed { get; init; }
    public string PublicKey { get; init; }
}