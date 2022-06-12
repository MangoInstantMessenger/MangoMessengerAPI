using MangoAPI.DiffieHellmanLibrary.Abstractions;

namespace MangoAPI.DiffieHellmanLibrary.CngHandlers;

public class CngPrintKeyExchangesHandler : BaseHandler, IPrintKeyExchangesHandler
{
    public CngPrintKeyExchangesHandler(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task PrintKeyExchangesAsync()
    {
        var userId = TokensResponse.Tokens.UserId;
        Console.WriteLine($@"Printing the list of key exchanges of the user {userId} ...");

        await CngPrintKeyExchangesListAsync();

        Console.WriteLine(@"Key exchanges printed successfully.");
        Console.WriteLine();
    }

    private async Task CngPrintKeyExchangesListAsync()
    {
        var response = await CngGetKeyExchangesAsync();
        response.OpenSslKeyExchangeRequests.ForEach(Console.WriteLine);
    }
}