using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpenSslGeneratePublicKeyHandler
{
    private readonly OpenSslKeyExchangeService _openSslKeyExchangeService;

    public OpenSslGeneratePublicKeyHandler(OpenSslKeyExchangeService openSslKeyExchangeService)
    {
        _openSslKeyExchangeService = openSslKeyExchangeService;
    }

    public async Task GeneratePublicKeyAsync(Guid receiverId)
    {
        Console.WriteLine(@"Generating public key ...");
        
        await _openSslKeyExchangeService.OpenSslGeneratePublicKeyAsync(receiverId);
        
        Console.WriteLine(@"Public key has been generated successfully.");
    }
}