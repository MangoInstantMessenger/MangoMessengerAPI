using MangoAPI.DiffieHellmanLibrary.Abstractions;
using MangoAPI.DiffieHellmanLibrary.Constants;
using MangoAPI.DiffieHellmanLibrary.Helpers;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpensslCreateKeyExchangeHandler : BaseHandler, ICreateKeyExchangeHandler
{
    public OpensslCreateKeyExchangeHandler(HttpClient httpClient)
        : base(httpClient)
    {
    }

    public async Task CreateKeyExchangeAsync(Guid receiverId)
    {
        Console.WriteLine($@"Generating a key exchange with the user {receiverId} ...");

        await OpenSslCreateKeyExchangeAsync(receiverId);

        Console.WriteLine($@"Key exchange with the user {receiverId} has been generated successfully.");
        Console.WriteLine();
    }

    private async Task OpenSslCreateKeyExchangeAsync(Guid receiverId)
    {
        var senderId = TokensResponse.Tokens.UserId;

        var workingDirectory = OpenSslDirectoryHelper.OpenSslPublicKeysDirectory;

        var publicKeyFileName = FileNameHelper.GenerateOpenSslPublicKeyFileName(senderId, receiverId);

        var publicKeyPath = Path.Combine(workingDirectory, publicKeyFileName);

        var route = $"{KeyExchangeRoutes.KeyExchangeRequests}/{receiverId}?keyExchangeType=2";

        var uri = new Uri(route, UriKind.Absolute);

        using var request = new HttpRequestMessage(HttpMethod.Post, uri);

        await using var stream = File.OpenRead(publicKeyPath);

        using var content = new MultipartFormDataContent
        {
            { new StreamContent(stream), "senderPublicKey", publicKeyFileName },
        };

        request.Content = content;

        var httpResponseMessage = await HttpClient.SendAsync(request);

        httpResponseMessage.EnsureSuccessStatusCode();
    }
}
