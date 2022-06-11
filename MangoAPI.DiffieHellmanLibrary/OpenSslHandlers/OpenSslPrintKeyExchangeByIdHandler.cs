using MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.DiffieHellmanLibrary.Constants;
using MangoAPI.DiffieHellmanLibrary.Services;
using Newtonsoft.Json;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpenSslPrintKeyExchangeByIdHandler : BaseHandler
{
    public OpenSslPrintKeyExchangeByIdHandler(HttpClient httpClient, TokensService tokensService) : base(httpClient,
        tokensService)
    {
    }

    public async Task GetKeyExchangeByIdAsync(Guid requestId)
    {
        Console.WriteLine($@"Reading the key exchange {requestId} ...");

        var exchangeRequest = await OpenSslGetKeyExchangeByIdAsync(requestId);

        Console.WriteLine(exchangeRequest);

        Console.WriteLine(@"Reading completed.");

        Console.WriteLine();
    }

    private async Task<OpenSslKeyExchangeRequest> OpenSslGetKeyExchangeByIdAsync(Guid requestId)
    {
        var address = $"{OpenSslRoutes.OpenSslKeyExchangeRequests}/{requestId}";
        var uri = new Uri(address, UriKind.Absolute);

        var response = await HttpClient.GetAsync(uri);
        response.EnsureSuccessStatusCode();

        var jsonAsString = await response.Content.ReadAsStringAsync();

        var deserializeObject =
            JsonConvert.DeserializeObject<OpenSslGetKeyExchangeRequestByIdResponse>(jsonAsString)
            ?? throw new InvalidOperationException();

        var exchangeRequest = deserializeObject.KeyExchangeRequest;

        return exchangeRequest;
    }
}