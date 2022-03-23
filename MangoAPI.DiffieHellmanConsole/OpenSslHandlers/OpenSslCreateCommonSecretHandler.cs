using System;
using System.Threading.Tasks;
using MangoAPI.DiffieHellmanConsole.Services;

namespace MangoAPI.DiffieHellmanConsole.OpenSslHandlers;

public class OpenSslCreateCommonSecretHandler
{
    private readonly KeyExchangeService _keyExchangeService;

    public OpenSslCreateCommonSecretHandler(KeyExchangeService keyExchangeService)
    {
        _keyExchangeService = keyExchangeService;
    }

    public async Task CreateCommonSecretAsync(Guid requestId)
    {
        Console.WriteLine($"Creating common secret {requestId} ...");
        await _keyExchangeService.OpensslCreateCommonSecretAsync(requestId);
        Console.WriteLine($"");
    }
}