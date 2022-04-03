using System;
using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiCommands.OpenSslKeyExchange;

public record OpenSslCreateDiffieHellmanParameterResponse : ResponseBase
{
    public Guid ParameterId { get; init; }
}