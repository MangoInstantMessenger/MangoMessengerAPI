using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpenSslDownloadPublicKeyHandler
{
    private readonly OpenSslKeyExchangeService _openSslKeyExchangeService;

    public OpenSslDownloadPublicKeyHandler(OpenSslKeyExchangeService openSslKeyExchangeService)
    {
        _openSslKeyExchangeService = openSslKeyExchangeService;
    }

    public async Task DownloadPublicKeyAsync(Guid requestId)
    {
        Console.WriteLine($@"Downloading public key, request {requestId} ...");

        await _openSslKeyExchangeService.OpensslDownloadPublicKeyAsync(requestId);

        Console.WriteLine($@"Public key, request {requestId} has been downloaded successfully.");
    }
}