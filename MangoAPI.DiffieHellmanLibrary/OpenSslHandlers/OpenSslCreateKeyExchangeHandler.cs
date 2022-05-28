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
        Console.WriteLine($@"Generating a key exchange with the user {receiverId} ...");
        
        await _openSslKeyExchangeService.OpenSslCreateKeyExchangeAsync(receiverId);
        
        Console.WriteLine($@"Key exchange with the user {receiverId} has been generated successfully.");
        Console.WriteLine();
    }
}