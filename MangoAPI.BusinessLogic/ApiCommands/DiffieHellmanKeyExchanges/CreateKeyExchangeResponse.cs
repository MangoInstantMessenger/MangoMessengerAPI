using System;
using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiCommands.DiffieHellmanKeyExchanges;

public record CreateKeyExchangeResponse : ResponseBase
{
    public Guid RequestId { get; init; }
}