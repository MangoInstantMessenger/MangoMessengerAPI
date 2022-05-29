using MangoAPI.BusinessLogic.Models;
using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpenSslDownloadPublicKeyHandler
{
    private readonly OpenSslKeyExchangeService _openSslKeyExchangeService;

    public OpenSslDownloadPublicKeyHandler(OpenSslKeyExchangeService openSslKeyExchangeService)
    {
        _openSslKeyExchangeService = openSslKeyExchangeService;
    }

    public async Task DownloadPublicKeyAsync(Actor actor, Guid userId)
    {
        Console.WriteLine($@"Downloading public key of the user {userId} ...");

        await _openSslKeyExchangeService.OpensslDownloadPublicKeyAsync(actor, userId);

        Console.WriteLine($@"Public key of the user {userId} has been downloaded successfully.");
        
        Console.WriteLine();
    }
}