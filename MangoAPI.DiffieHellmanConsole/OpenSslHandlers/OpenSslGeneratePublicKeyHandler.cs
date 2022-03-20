using System;
using System.Threading.Tasks;
using MangoAPI.DiffieHellmanConsole.Services;

namespace MangoAPI.DiffieHellmanConsole.OpenSslHandlers;

public class OpenSslGeneratePublicKeyHandler
{
    private readonly KeyExchangeService _keyExchangeService;

    public OpenSslGeneratePublicKeyHandler(KeyExchangeService keyExchangeService)
    {
        _keyExchangeService = keyExchangeService;
    }

    public async Task GeneratePublicKeyAsync(Guid receiverId)
    {
        Console.WriteLine("Generating public key ...");
        
        await _keyExchangeService.OpenSslGeneratePublicKeyAsync(receiverId);
        
        Console.WriteLine("Public key has been generated successfully.");
    }
}