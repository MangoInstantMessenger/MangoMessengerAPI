namespace MangoAPI.DiffieHellmanLibrary.Abstractions;

public interface IConfirmKeyExchangeHandler
{
    Task ConfirmKeyExchangeAsync(Guid senderId);
}