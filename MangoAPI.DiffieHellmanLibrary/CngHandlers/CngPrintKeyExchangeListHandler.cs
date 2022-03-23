using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.CngHandlers;

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