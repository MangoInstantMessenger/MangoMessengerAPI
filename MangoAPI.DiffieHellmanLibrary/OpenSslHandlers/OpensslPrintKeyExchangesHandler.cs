using MangoAPI.DiffieHellmanLibrary.Abstractions;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpensslPrintKeyExchangesHandler : BaseHandler, IPrintKeyExchangesHandler
{
    public OpensslPrintKeyExchangesHandler(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task PrintKeyExchangesAsync()
    {
        Console.WriteLine(@"Printing key-exchange requests ...");

        var list = await GetKeyExchangesAsync();

        list.ForEach(Console.WriteLine);

        Console.WriteLine(@"Key exchanges are printed successfully.");

        Console.WriteLine();
    }
}