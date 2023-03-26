using System.Text.Json;
using MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.DiffieHellmanLibrary.Abstractions;
using MangoAPI.DiffieHellmanLibrary.Constants;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpensslPrintKeyExchangeByIdHandler : BaseHandler, IPrintKeyExchangeByIdHandler
{
    public OpensslPrintKeyExchangeByIdHandler(HttpClient httpClient)
        : base(httpClient)
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
        var address = $"{KeyExchangeRoutes.KeyExchangeRequests}/{requestId}";
        var uri = new Uri(address, UriKind.Absolute);

        var response = await HttpClient.GetAsync(uri);
        response.EnsureSuccessStatusCode();

        var jsonAsString = await response.Content.ReadAsStringAsync();

        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var deserializeObject =
            JsonSerializer.Deserialize<GetKeyExchangeRequestByIdResponse>(jsonAsString, options)
            ?? throw new InvalidOperationException();

        var exchangeRequest = deserializeObject.KeyExchangeRequest;

        return exchangeRequest;
    }
}