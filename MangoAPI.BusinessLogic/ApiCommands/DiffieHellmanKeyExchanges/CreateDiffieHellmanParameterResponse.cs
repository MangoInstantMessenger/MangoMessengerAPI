using System;
using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiCommands.DiffieHellmanKeyExchanges;

public record CreateDiffieHellmanParameterResponse : ResponseBase
{
    public Guid ParameterId { get; init; }
}