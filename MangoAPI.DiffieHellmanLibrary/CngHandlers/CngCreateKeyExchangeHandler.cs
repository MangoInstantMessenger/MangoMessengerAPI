using MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;
using MangoAPI.DiffieHellmanLibrary.Abstractions;
using MangoAPI.DiffieHellmanLibrary.Constants;
using MangoAPI.DiffieHellmanLibrary.Extensions;
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
        var tokens = TokensResponse.Tokens;

        CngEcdhHelper.CngGenerateEcdhKeysPair(out var privateKeyBase64, out var publicKeyBase64);

        var response = await CngCreateKeyExchangeRequestAsync(receiverId, publicKeyBase64);

        Console.WriteLine($@"Key exchange request with an ID {response.RequestId} created successfully.");

        var privateKeysDirectory = CngDirectoryHelper.CngPrivateKeysDirectory;
        var publicKeysDirectory = CngDirectoryHelper.CngPublicKeysDirectory;

        var privateKeyPath = Path.Combine(
            privateKeysDirectory,
            $"PRIVATE_KEY_{tokens.UserId}_{receiverId}.txt");

        var publicKeyPath = Path.Combine(
            publicKeysDirectory,
            $"PUBLIC_KEY_{tokens.UserId}_{receiverId}.txt");

        privateKeysDirectory.CreateDirectoryIfNotExist();
        publicKeysDirectory.CreateDirectoryIfNotExist();

        Console.WriteLine(@"Writing private key to file...");
        await File.WriteAllTextAsync(privateKeyPath, privateKeyBase64);

        Console.WriteLine(@"Writing public key to file ...");
        await File.WriteAllTextAsync(publicKeyPath, publicKeyBase64);

        Console.WriteLine(@"Key exchange request sent successfully.");
        Console.WriteLine();
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