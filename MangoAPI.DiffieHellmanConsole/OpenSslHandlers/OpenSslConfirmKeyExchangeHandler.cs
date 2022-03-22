using System;
using System.Threading.Tasks;
using MangoAPI.DiffieHellmanConsole.Services;

namespace MangoAPI.DiffieHellmanConsole.OpenSslHandlers;

public class OpenSslConfirmKeyExchangeHandler
{
    private readonly KeyExchangeService _keyExchangeService;

    public OpenSslConfirmKeyExchangeHandler(KeyExchangeService keyExchangeService)
    {
        _keyExchangeService = keyExchangeService;
    }

    public async Task ConfirmKeyExchangeAsync(Guid requestId)
    {
        Console.WriteLine($"Confirming key exchange request {requestId} ... ");
        await _keyExchangeService.OpensslConfirmKeyExchange(requestId);
        Console.WriteLine($"Key exchange request {requestId} has been confirmed successfully.");
    }
}