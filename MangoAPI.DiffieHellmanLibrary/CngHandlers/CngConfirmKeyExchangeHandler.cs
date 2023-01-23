using MangoAPI.DiffieHellmanLibrary.Abstractions;
using MangoAPI.DiffieHellmanLibrary.Constants;
using MangoAPI.DiffieHellmanLibrary.Helpers;
using MangoAPI.Domain.Enums;

namespace MangoAPI.DiffieHellmanLibrary.CngHandlers;

public class CngConfirmKeyExchangeHandler : BaseHandler, IConfirmKeyExchangeHandler
{
    public CngConfirmKeyExchangeHandler(HttpClient httpClient)
        : base(httpClient)
    {
    }

    public async Task ConfirmKeyExchangeAsync(Guid senderId)
    {
        Console.WriteLine($@"Confirming key exchange with the user {senderId} ... ");

        await CngConfirmKeyExchangeRequestAsync(senderId);

        Console.WriteLine($@"Key exchange request with the user {senderId} has been confirmed successfully.");
        Console.WriteLine();
    }

    private async Task CngConfirmKeyExchangeRequestAsync(Guid senderId)
    {
        var userId = TokensResponse.Tokens.UserId;

        var allRequestsList = await GetKeyExchangesAsync();

        var keyExchangeRequest = allRequestsList.First(x =>
            x.SenderId == senderId &&
            x.ReceiverId == userId &&
            !x.IsConfirmed &&
            x.KeyExchangeType == KeyExchangeType.Cng);

        var publicKeyDirectory = CngDirectoryHelper.CngPublicKeysDirectory;
        var publicKeyFileName = FileNameHelper.GenerateCngPublicKeyFileName(userId, senderId);
        var publicKeyPath = Path.Combine(publicKeyDirectory, publicKeyFileName);

        var route = $"{KeyExchangeRoutes.KeyExchangeRequests}/{keyExchangeRequest.RequestId}";

        var uri = new Uri(route, UriKind.Absolute);

        using var request = new HttpRequestMessage(HttpMethod.Put, uri);

        await using var stream = File.OpenRead(publicKeyPath);

        using var content = new MultipartFormDataContent
        {
            { new StreamContent(stream), "receiverPublicKey", publicKeyFileName },
        };

        request.Content = content;

        var httpResponseMessage = await HttpClient.SendAsync(request);

        _ = httpResponseMessage.EnsureSuccessStatusCode();
    }
}
