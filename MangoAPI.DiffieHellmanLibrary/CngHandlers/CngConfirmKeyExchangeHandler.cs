using MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;
using MangoAPI.DiffieHellmanLibrary.Abstractions;
using MangoAPI.DiffieHellmanLibrary.Constants;
using MangoAPI.DiffieHellmanLibrary.Helpers;
using MangoAPI.Domain.Enums;

namespace MangoAPI.DiffieHellmanLibrary.CngHandlers;

public class CngConfirmKeyExchangeHandler : BaseHandler, IConfirmKeyExchangeHandler
{
    public CngConfirmKeyExchangeHandler(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task ConfirmKeyExchangeAsync(Guid senderId)
    {
        Console.WriteLine($@"Confirming key exchange with the user {senderId} ... ");

        await CngConfirmKeyExchangeRequest(senderId);

        Console.WriteLine($@"Key exchange request with the user {senderId} has been confirmed successfully.");
        Console.WriteLine();
    }

    private async Task CngConfirmKeyExchangeRequest(Guid senderId)
    {
        var userId = TokensResponse.Tokens.UserId;

        var allRequestsList = (await CngGetKeyExchangesAsync()).OpenSslKeyExchangeRequests;

        var keyExchangeRequest = allRequestsList.First(x =>
            x.SenderId == senderId &&
            x.ReceiverId == userId &&
            !x.IsConfirmed &&
            x.KeyExchangeType == KeyExchangeType.Cng);

        var publicKeyDirectory = CngDirectoryHelper.CngPublicKeysDirectory;
        var publicKeyFileName = FileNameHelper.GenerateCngPublicKeyFileName(userId, senderId);
        var publicKeyPath = Path.Combine(publicKeyDirectory, publicKeyFileName);
        
        var route = $"{CngRoutes.CngKeyExchangeRequests}/{keyExchangeRequest.RequestId}";

        var uri = new Uri(route, UriKind.Absolute);
        
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

    private async Task CngConfirmKeyExchangeAsync(Guid requestId, string publicKeyBase64)
    {
        var request = new CngConfirmOrDeclineKeyExchangeRequest
        {
            Confirmed = true,
            PublicKey = publicKeyBase64,
            RequestId = requestId
        };

        await HttpRequestHelper.DeleteWithBodyAsync(
            client: HttpClient,
            route: CngRoutes.CngKeyExchangeRequests,
            body: request);
    }
}