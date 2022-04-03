using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpenSslPrintKeyExchangesHandler
{
    private readonly OpenSslKeyExchangeService _openSslKeyExchangeService;

    public OpenSslPrintKeyExchangesHandler(OpenSslKeyExchangeService openSslKeyExchangeService)
    {
        _openSslKeyExchangeService = openSslKeyExchangeService;
    }

    public async Task PrintKeyExchangesAsync()
    {
        Console.WriteLine("Printing key-exchange requests ...");
        
        var list = await _openSslKeyExchangeService.OpensslGetKeyExchangesAsync();
        
        list.ForEach(Console.WriteLine);
        
        Console.WriteLine("Key exchanges has been printed successfully.");
    }
}