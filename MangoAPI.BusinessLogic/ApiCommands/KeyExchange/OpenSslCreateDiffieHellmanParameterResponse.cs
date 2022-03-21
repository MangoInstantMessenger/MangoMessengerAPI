using System;
using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiCommands.KeyExchange;

public record OpenSslCreateDiffieHellmanParameterResponse : ResponseBase
{
    public Guid ParameterId { get; init; }
}