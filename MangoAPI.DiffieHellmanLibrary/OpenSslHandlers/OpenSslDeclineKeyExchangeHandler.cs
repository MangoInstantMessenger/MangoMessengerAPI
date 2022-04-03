using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpenSslDeclineKeyExchangeHandler
{
    private readonly OpenSslKeyExchangeService _openSslKeyExchangeService;

    public OpenSslDeclineKeyExchangeHandler(OpenSslKeyExchangeService openSslKeyExchangeService)
    {
        _openSslKeyExchangeService = openSslKeyExchangeService;
    }

    public async Task DeclineKeyExchangeAsync(Guid requestId)
    {
        Console.WriteLine($"Declining key exchange request {requestId} ...");
        
        await _openSslKeyExchangeService.OpenSslDeclineKeyExchangeAsync(requestId);
        
        Console.WriteLine($"key exchange request {requestId} has been declined.");
    }
}