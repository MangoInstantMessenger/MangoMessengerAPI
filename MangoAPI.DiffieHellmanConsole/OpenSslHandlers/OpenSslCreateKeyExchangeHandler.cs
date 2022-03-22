using System;
using System.Threading.Tasks;
using MangoAPI.DiffieHellmanConsole.Services;

namespace MangoAPI.DiffieHellmanConsole.OpenSslHandlers;

public class OpenSslCreateKeyExchangeHandler
{
    private readonly KeyExchangeService _keyExchangeService;

    public OpenSslCreateKeyExchangeHandler(KeyExchangeService keyExchangeService)
    {
        _keyExchangeService = keyExchangeService;
    }

    public async Task CreateKeyExchangeAsync(Guid receiverId)
    {
        Console.WriteLine("Creating key exchange request ...");
        await _keyExchangeService.OpenSslCreateKeyExchangeAsync(receiverId);
        Console.WriteLine($"Key exchange with {receiverId} has been created successfully.");
    }
}