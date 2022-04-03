using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpenSslCreateKeyExchangeHandler
{
    private readonly OpenSslKeyExchangeService _openSslKeyExchangeService;

    public OpenSslCreateKeyExchangeHandler(OpenSslKeyExchangeService openSslKeyExchangeService)
    {
        _openSslKeyExchangeService = openSslKeyExchangeService;
    }

    public async Task CreateKeyExchangeAsync(Guid receiverId)
    {
        Console.WriteLine("Creating key exchange request ...");
        await _openSslKeyExchangeService.OpenSslCreateKeyExchangeAsync(receiverId);
        Console.WriteLine($"Key exchange with {receiverId} has been created successfully.");
    }
}