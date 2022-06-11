using MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;
using MangoAPI.DiffieHellmanLibrary.Abstractions;
using MangoAPI.DiffieHellmanLibrary.Constants;
using MangoAPI.DiffieHellmanLibrary.Helpers;
using Newtonsoft.Json;

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

    private async Task<OpenSslGetKeyExchangeRequestsResponse> CngGetKeyExchangesAsync()
    {
        var result = await HttpRequestHelper.GetAsync(
            client: HttpClient,
            route: CngRoutes.CngKeyExchangeRequests);

        var response = JsonConvert.DeserializeObject<OpenSslGetKeyExchangeRequestsResponse>(result);

        return response ?? throw new InvalidOperationException();
    }
}