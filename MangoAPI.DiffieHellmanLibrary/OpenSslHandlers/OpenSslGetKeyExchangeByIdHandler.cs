using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpenSslGetKeyExchangeByIdHandler
{
    private readonly OpenSslKeyExchangeService _openSslKeyExchangeService;

    public OpenSslGetKeyExchangeByIdHandler(OpenSslKeyExchangeService openSslKeyExchangeService)
    {
        _openSslKeyExchangeService = openSslKeyExchangeService;
    }

    public async Task GetKeyExchangeByIdAsync(Guid requestId)
    {
        Console.WriteLine($@"Reading the key exchange {requestId} ...");

        var exchangeRequest = await _openSslKeyExchangeService.OpenSslGetKeyExchangeByIdAsync(requestId);

        Console.WriteLine(exchangeRequest);

        Console.WriteLine(@"Reading completed.");
        
        Console.WriteLine();
    }
}