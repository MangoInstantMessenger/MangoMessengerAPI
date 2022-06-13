namespace MangoAPI.DiffieHellmanLibrary.Abstractions;

public interface IPrintKeyExchangeByIdHandler
{
    Task GetKeyExchangeByIdAsync(Guid requestId);
}