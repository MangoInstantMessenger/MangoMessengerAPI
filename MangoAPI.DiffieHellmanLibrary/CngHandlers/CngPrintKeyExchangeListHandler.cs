using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.CngHandlers;

public class CngPrintKeyExchangeListHandler
{
    private readonly CngKeyExchangeService _cngKeyExchangeService;

    public CngPrintKeyExchangeListHandler(CngKeyExchangeService cngKeyExchangeService)
    {
        _cngKeyExchangeService = cngKeyExchangeService;
    }

    public async Task CngPrintKeyExchangesListAsync()
    {
        var response = await _cngKeyExchangeService.CngGetKeyExchangesAsync();
        response.KeyExchangeRequests.ForEach(Console.WriteLine);
    }
}