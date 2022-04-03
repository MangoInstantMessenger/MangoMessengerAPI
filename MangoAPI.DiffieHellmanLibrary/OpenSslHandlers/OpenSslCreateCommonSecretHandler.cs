using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpenSslCreateCommonSecretHandler
{
    private readonly OpenSslKeyExchangeService _openSslKeyExchangeService;

    public OpenSslCreateCommonSecretHandler(OpenSslKeyExchangeService openSslKeyExchangeService)
    {
        _openSslKeyExchangeService = openSslKeyExchangeService;
    }

    public async Task CreateCommonSecretAsync(Guid requestId)
    {
        Console.WriteLine($"Creating common secret {requestId} ...");
        
        await _openSslKeyExchangeService.OpensslCreateCommonSecretAsync(requestId);
        
        Console.WriteLine($"Common secret has been successfully created.");
    }
}