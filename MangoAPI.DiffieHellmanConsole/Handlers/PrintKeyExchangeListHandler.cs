using System;
using System.Threading.Tasks;
using MangoAPI.DiffieHellmanConsole.Services;

namespace MangoAPI.DiffieHellmanConsole.Handlers;

public class PrintKeyExchangeListHandler
{
    private readonly KeyExchangeService _keyExchangeService;

    public PrintKeyExchangeListHandler(KeyExchangeService keyExchangeService)
    {
        _keyExchangeService = keyExchangeService;
    }

    public async Task PrintKeyExchangesListAsync()
    {
        var response = await _keyExchangeService.GetKeyExchangesAsync();
        response.KeyExchangeRequests.ForEach(Console.WriteLine);
    }
}