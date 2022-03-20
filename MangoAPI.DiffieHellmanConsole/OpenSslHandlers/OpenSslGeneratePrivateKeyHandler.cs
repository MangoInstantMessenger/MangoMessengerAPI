using System;
using System.Threading.Tasks;
using MangoAPI.DiffieHellmanConsole.Services;

namespace MangoAPI.DiffieHellmanConsole.OpenSslHandlers;

public class OpenSslGeneratePrivateKeyHandler
{
    private readonly KeyExchangeService _keyExchangeService;

    public OpenSslGeneratePrivateKeyHandler(KeyExchangeService keyExchangeService)
    {
        _keyExchangeService = keyExchangeService;
    }

    public async Task GeneratePrivateKeyAsync(Guid receiverId)
    {
        Console.WriteLine("Generating private key ...");
        
        await _keyExchangeService.OpenSslGeneratePrivateKeyAsync(receiverId);
        
        Console.WriteLine("Private key has been generated successfully.");
    }
}