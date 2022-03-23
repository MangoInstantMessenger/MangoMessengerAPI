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

    public async Task CngPrintKeyExchangesListAsync()
    {
        var response = await _keyExchangeService.CngGetKeyExchangesAsync();
        response.KeyExchangeRequests.ForEach(Console.WriteLine);
    }
}