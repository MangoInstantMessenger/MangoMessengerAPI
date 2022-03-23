using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpenSslGeneratePrivateKeyHandler
{
    private readonly KeyExchangeService _keyExchangeService;

    public OpenSslGeneratePrivateKeyHandler(KeyExchangeService keyExchangeService)
    {
        _keyExchangeService = keyExchangeService;
    }

    public async Task GeneratePrivateKeyAsync(Guid receiverId)
    {
        Console.WriteLine("Generating private key ...");
        
        await _keyExchangeService.OpenSslGeneratePrivateKeyAsync(receiverId);
        
        Console.WriteLine("Private key has been generated successfully.");
    }
}