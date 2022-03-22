using System;
using System.Threading.Tasks;
using MangoAPI.DiffieHellmanConsole.Services;

namespace MangoAPI.DiffieHellmanConsole.OpenSslHandlers;

public class OpenSslPrintKeyExchangesHandler
{
    private readonly KeyExchangeService _keyExchangeService;

    public OpenSslPrintKeyExchangesHandler(KeyExchangeService keyExchangeService)
    {
        _keyExchangeService = keyExchangeService;
    }

    public async Task PrintKeyExchangesAsync()
    {
        Console.WriteLine("Printing key-exchange requests ...");
        var list = await _keyExchangeService.OpensslGetKeyExchangesAsync();
        list.ForEach(Console.WriteLine);
        Console.WriteLine("Key exchanges has been printed successfully.");
    }
}