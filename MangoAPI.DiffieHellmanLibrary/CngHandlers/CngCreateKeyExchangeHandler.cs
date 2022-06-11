using MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;
using MangoAPI.DiffieHellmanLibrary.Abstractions;
using MangoAPI.DiffieHellmanLibrary.Constants;
using MangoAPI.DiffieHellmanLibrary.Helpers;
using Newtonsoft.Json;

namespace MangoAPI.DiffieHellmanLibrary.CngHandlers;

public class CngCreateKeyExchangeHandler : BaseHandler, ICreateKeyExchangeHandler
{
    public CngCreateKeyExchangeHandler(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task CreateKeyExchangeAsync(Guid receiverId)
    {
        await CngRequestKeyExchange(receiverId);
    }

    private async Task CngRequestKeyExchange(Guid receiverId)
    {
        var senderId = TokensResponse.Tokens.UserId;

        var workingDirectory = CngDirectoryHelper.CngPublicKeysDirectory;

        var publicKeyFileName = FileNameHelper.GenerateCngPublicKeyFileName(senderId, receiverId);

        var publicKeyPath = Path.Combine(workingDirectory, publicKeyFileName);

        var route = $"{CngRoutes.CngKeyExchangeRequests}/{receiverId}";

        var uri = new Uri(route, UriKind.Absolute);

        using var request = new HttpRequestMessage(HttpMethod.Post, uri);

        await using var stream = File.OpenRead(publicKeyPath);

        using var content = new MultipartFormDataContent
        {
            { new StreamContent(stream), "senderPublicKey", publicKeyFileName }
        };

        request.Content = content;

        var httpResponseMessage = await HttpClient.SendAsync(request);

        httpResponseMessage.EnsureSuccessStatusCode();
    }

    private async Task<CngCreateKeyExchangeResponse> CngCreateKeyExchangeRequestAsync(
        Guid requestUserId,
        string publicKey)
    {
        var command = new CngCreateKeyExchangeRequest
        {
            PublicKey = publicKey,
            RequestedUserId = requestUserId
        };

        var result = await HttpRequestHelper.PostWithBodyAsync(
            client: HttpClient,
            route: CngRoutes.CngKeyExchangeRequests,
            body: command);

        var response = JsonConvert.DeserializeObject<CngCreateKeyExchangeResponse>(result);

        return response ?? throw new InvalidOperationException();
    }
}