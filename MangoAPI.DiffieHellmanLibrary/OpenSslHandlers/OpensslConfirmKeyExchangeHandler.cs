using MangoAPI.DiffieHellmanLibrary.Abstractions;
using MangoAPI.DiffieHellmanLibrary.Constants;
using MangoAPI.DiffieHellmanLibrary.Helpers;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpensslConfirmKeyExchangeHandler : BaseHandler, IConfirmKeyExchangeHandler
{
    public OpensslConfirmKeyExchangeHandler(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task ConfirmKeyExchangeAsync(Guid senderId)
    {
        Console.WriteLine($@"Confirming key exchange with the user {senderId} ... ");

        await OpensslConfirmKeyExchange(senderId);

        Console.WriteLine($@"Key exchange request with the user {senderId} has been confirmed successfully.");
        Console.WriteLine();
    }

    private async Task OpensslConfirmKeyExchange(Guid senderId)
    {
        var allRequests = await GetKeyExchangesAsync();
        
        var currentUserId = TokensResponse.Tokens.UserId;

        var keyExchangeRequest = allRequests.FirstOrDefault(x =>
            x.SenderId == senderId && x.ReceiverId == currentUserId);

        if (keyExchangeRequest == null)
        {
            throw new InvalidOperationException();
        }

        var route = $"{KeyExchangeRoutes.KeyExchangeRequests}/{keyExchangeRequest.RequestId}";

        var uri = new Uri(route, UriKind.Absolute);

        var workingDirectory = OpenSslDirectoryHelper.OpenSslPublicKeysDirectory;

        var publicKeyFileName = FileNameHelper.GenerateOpenSslPublicKeyFileName(currentUserId, senderId);

        var publicKeyPath = Path.Combine(workingDirectory, publicKeyFileName);

        using var request = new HttpRequestMessage(HttpMethod.Put, uri);

        await using var stream = File.OpenRead(publicKeyPath);

        using var content = new MultipartFormDataContent
        {
            { new StreamContent(stream), "receiverPublicKey", publicKeyFileName }
        };

        request.Content = content;

        var httpResponseMessage = await HttpClient.SendAsync(request);

        httpResponseMessage.EnsureSuccessStatusCode();
    }
}