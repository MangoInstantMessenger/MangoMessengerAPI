using MangoAPI.DiffieHellmanLibrary.Abstractions;
using MangoAPI.DiffieHellmanLibrary.Constants;
using MangoAPI.DiffieHellmanLibrary.Helpers;
using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class ConfirmKeyExchangeHandler : BaseHandler, IConfirmKeyExchangeHandler
{
    public ConfirmKeyExchangeHandler(HttpClient httpClient) : base(httpClient)
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
        var allRequests = await OpensslGetKeyExchangesAsync();

        var tokensResponse = await TokensService.GetTokensAsync();
        var currentUserId = tokensResponse.Tokens.UserId;

        var keyExchangeRequest = allRequests.FirstOrDefault(x =>
            x.SenderId == senderId && x.ReceiverId == currentUserId);

        if (keyExchangeRequest == null)
        {
            throw new InvalidOperationException();
        }

        var route = $"{OpenSslRoutes.OpenSslKeyExchangeRequests}/{keyExchangeRequest.RequestId}";

        var uri = new Uri(route, UriKind.Absolute);

        var workingDirectory = OpenSslDirectoryHelper.OpenSslPublicKeysDirectory;

        var publicKeyFileName = FileNameHelper.GeneratePublicKeyFileName(currentUserId, senderId);

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