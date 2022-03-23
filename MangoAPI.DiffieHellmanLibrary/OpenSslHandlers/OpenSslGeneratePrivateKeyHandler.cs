using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpenSslGeneratePrivateKeyHandler
{
    private readonly OpenSslKeyExchangeService _openSslKeyExchangeService;

    public OpenSslGeneratePrivateKeyHandler(OpenSslKeyExchangeService openSslKeyExchangeService)
    {
        _openSslKeyExchangeService = openSslKeyExchangeService;
    }

    public async Task GeneratePrivateKeyAsync(Guid receiverId)
    {
        Console.WriteLine("Generating private key ...");

        await _openSslKeyExchangeService.OpenSslGeneratePrivateKeyAsync(receiverId);

        Console.WriteLine("Private key has been generated successfully.");
    }
}