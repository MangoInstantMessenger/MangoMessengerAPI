using MangoAPI.DiffieHellmanLibrary.Abstractions;
using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpenSslPrintKeyExchangesHandler : BaseHandler, IPrintKeyExchangesHandler
{
    public OpenSslPrintKeyExchangesHandler(HttpClient httpClient, TokensService tokensService) : base(httpClient,
        tokensService)
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