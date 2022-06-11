using MangoAPI.DiffieHellmanLibrary.Abstractions;
using MangoAPI.DiffieHellmanLibrary.Constants;
using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpenSslDeclineKeyExchangeHandler : BaseHandler, IDeclineKeyExchangeHandler
{
    public OpenSslDeclineKeyExchangeHandler(HttpClient httpClient, TokensService tokensService) : base(httpClient,
        tokensService)
    {
    }

    public async Task DeclineKeyExchangeAsync(Guid requestId)
    {
        Console.WriteLine($@"Declining key exchange request {requestId} ...");

        await OpenSslDeclineKeyExchangeAsync(requestId);

        Console.WriteLine($@"key exchange request {requestId} has been declined.");
        Console.WriteLine();
    }

    private async Task OpenSslDeclineKeyExchangeAsync(Guid requestId)
    {
        var address = $"{OpenSslRoutes.OpenSslKeyExchangeRequests}/{requestId}";
        var uri = new Uri(address, UriKind.Absolute);

        var httpResponseMessage = await HttpClient.DeleteAsync(uri);
        httpResponseMessage.EnsureSuccessStatusCode();
    }
}