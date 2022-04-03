using System;
using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;

public record CngCreateKeyExchangeResponse : ResponseBase
{
    public Guid RequestId { get; init; }
}