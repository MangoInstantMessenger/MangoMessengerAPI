namespace MangoAPI.DiffieHellmanLibrary.Abstractions;

public interface ICreateKeyExchangeHandler
{
    Task CreateKeyExchangeAsync(Guid receiverId);
}