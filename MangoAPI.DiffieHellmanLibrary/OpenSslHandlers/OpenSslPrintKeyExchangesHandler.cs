using MangoAPI.DiffieHellmanLibrary.Abstractions;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpenSslPrintKeyExchangesHandler : OpenSslBaseHandler, IPrintKeyExchangesHandler
{
    public OpenSslPrintKeyExchangesHandler(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task PrintKeyExchangesAsync()
    {
        Console.WriteLine(@"Printing key-exchange requests ...");

        var list = await OpensslGetKeyExchangesAsync();

        list.ForEach(Console.WriteLine);

        Console.WriteLine(@"Key exchanges are printed successfully.");

        Console.WriteLine();
    }
}