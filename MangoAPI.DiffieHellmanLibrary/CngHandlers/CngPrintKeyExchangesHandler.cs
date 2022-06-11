using MangoAPI.BusinessLogic.ApiQueries.CngKeyExchange;
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
        await CngPrintKeyExchangesListAsync();
    }

    private async Task CngPrintKeyExchangesListAsync()
    {
        var response = await CngGetKeyExchangesAsync();
        response.KeyExchangeRequests.ForEach(Console.WriteLine);
    }

    private async Task<CngGetKeyExchangeResponse> CngGetKeyExchangesAsync()
    {
        var result = await HttpRequestHelper.GetAsync(
            client: HttpClient,
            route: CngRoutes.CngKeyExchangeRequests);

        var response = JsonConvert.DeserializeObject<CngGetKeyExchangeResponse>(result);

        return response ?? throw new InvalidOperationException();
    }
}