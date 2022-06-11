using MangoAPI.DiffieHellmanLibrary.Abstractions;
using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.CngHandlers;

public class CngPrintKeyExchangesHandler : IPrintKeyExchangesHandler
{
    private readonly CngKeyExchangeService _cngKeyExchangeService;

    public CngPrintKeyExchangesHandler(CngKeyExchangeService cngKeyExchangeService)
    {
        _cngKeyExchangeService = cngKeyExchangeService;
    }

    public async Task PrintKeyExchangesAsync()
    {
        await CngPrintKeyExchangesListAsync();
    }

    private async Task CngPrintKeyExchangesListAsync()
    {
        var response = await _cngKeyExchangeService.CngGetKeyExchangesAsync();
        response.KeyExchangeRequests.ForEach(Console.WriteLine);
    }
}