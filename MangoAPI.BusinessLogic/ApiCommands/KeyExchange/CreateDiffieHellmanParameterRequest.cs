namespace MangoAPI.BusinessLogic.ApiCommands.KeyExchange;

public record CreateDiffieHellmanParameterRequest
{
    public byte[] DiffieHellmanParameter { get; init; }
}