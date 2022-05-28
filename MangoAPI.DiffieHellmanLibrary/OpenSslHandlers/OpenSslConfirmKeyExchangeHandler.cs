using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpenSslConfirmKeyExchangeHandler
{
    private readonly OpenSslKeyExchangeService _openSslKeyExchangeService;

    public OpenSslConfirmKeyExchangeHandler(OpenSslKeyExchangeService openSslKeyExchangeService)
    {
        _openSslKeyExchangeService = openSslKeyExchangeService;
    }

    public async Task ConfirmKeyExchangeAsync(Guid requestId)
    {
        Console.WriteLine($@"Confirming key exchange request {requestId} ... ");
        await _openSslKeyExchangeService.OpensslConfirmKeyExchange(requestId);
        Console.WriteLine($@"Key exchange request {requestId} has been confirmed successfully.");
    }
}