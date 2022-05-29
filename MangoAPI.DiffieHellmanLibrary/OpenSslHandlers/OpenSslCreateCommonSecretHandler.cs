using MangoAPI.BusinessLogic.Models;
using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpenSslCreateCommonSecretHandler
{
    private readonly OpenSslKeyExchangeService _openSslKeyExchangeService;

    public OpenSslCreateCommonSecretHandler(OpenSslKeyExchangeService openSslKeyExchangeService)
    {
        _openSslKeyExchangeService = openSslKeyExchangeService;
    }

    public async Task CreateCommonSecretAsync(Actor actor, Guid userId)
    {
        Console.WriteLine($@"Creating common secret with the user {userId} ...");

        await _openSslKeyExchangeService.OpensslCreateCommonSecretAsync(actor, userId);

        Console.WriteLine($@"Common secret with the user {userId} has been successfully created.");
        Console.WriteLine();
    }
}