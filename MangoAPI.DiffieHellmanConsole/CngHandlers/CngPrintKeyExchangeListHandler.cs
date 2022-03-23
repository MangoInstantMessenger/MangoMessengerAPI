using System;
using System.Threading.Tasks;
using MangoAPI.DiffieHellmanConsole.Services;

namespace MangoAPI.DiffieHellmanConsole.CngHandlers;

public class CngPrintKeyExchangeListHandler
{
    private readonly KeyExchangeService _keyExchangeService;

    public CngPrintKeyExchangeListHandler(KeyExchangeService keyExchangeService)
    {
        _keyExchangeService = keyExchangeService;
    }

    public async Task PrintKeyExchangesListAsync()
    {
        var response = await _keyExchangeService.GetKeyExchangesAsync();
        response.KeyExchangeRequests.ForEach(Console.WriteLine);
    }
}