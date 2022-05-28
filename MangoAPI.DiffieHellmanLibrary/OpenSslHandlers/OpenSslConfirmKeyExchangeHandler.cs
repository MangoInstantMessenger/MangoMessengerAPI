using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpenSslConfirmKeyExchangeHandler
{
    private readonly OpenSslKeyExchangeService _openSslKeyExchangeService;

    public OpenSslConfirmKeyExchangeHandler(OpenSslKeyExchangeService openSslKeyExchangeService)
    {
        _openSslKeyExchangeService = openSslKeyExchangeService;
    }

    public async Task ConfirmKeyExchangeAsync(Guid senderId)
    {
        Console.WriteLine($@"Confirming key exchange with the user {senderId} ... ");
        
        await _openSslKeyExchangeService.OpensslConfirmKeyExchange(senderId);
        
        Console.WriteLine($@"Key exchange request with user {senderId} has been confirmed successfully.");
    }
}