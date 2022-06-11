using System.Security.Cryptography;
using MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;
using MangoAPI.BusinessLogic.ApiQueries.CngKeyExchange;
using MangoAPI.DiffieHellmanLibrary.Abstractions;
using MangoAPI.DiffieHellmanLibrary.Constants;
using MangoAPI.DiffieHellmanLibrary.Extensions;
using MangoAPI.DiffieHellmanLibrary.Helpers;
using Newtonsoft.Json;

namespace MangoAPI.DiffieHellmanLibrary.CngHandlers;

public class CngConfirmKeyExchangeHandler : BaseHandler, IConfirmKeyExchangeHandler
{
    public CngConfirmKeyExchangeHandler(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task ConfirmKeyExchangeAsync(Guid senderId)
    {
        await CngConfirmKeyExchangeRequest(senderId);
    }

    private async Task CngConfirmKeyExchangeRequest(Guid requestId)
    {
        var tokens = TokensResponse.Tokens;

        var getKeyExchangeResponse = await CngGetKeyExchangeById(requestId);
        var exchangeRequest = getKeyExchangeResponse.KeyExchangeRequest;

        var ecDiffieHellmanCng = CngEcdhHelper.CngGenerateEcdhKeysPair(
            out var privateKeyBase64String,
            out var publicKeyBase64String);

        var requestPublicKeyBytes = exchangeRequest.SenderPublicKey.Base64StringAsBytes();
        
        var requestPublicKey = CngKey.Import(requestPublicKeyBytes, CngKeyBlobFormat.EccPublicBlob);
        
        var commonSecret = ecDiffieHellmanCng.DeriveKeyMaterial(requestPublicKey).AsBase64String();

        await CngConfirmKeyExchangeAsync(requestId, publicKeyBase64String);

        var privateKeysDirectory = CngDirectoryHelper.CngPrivateKeysDirectory;
        var publicKeysDirectory = CngDirectoryHelper.CngPublicKeysDirectory;
        var commonSecretsDirectory = CngDirectoryHelper.CngCommonSecretsDirectory;

        var privateKeyPath = Path.Combine(
            privateKeysDirectory,
            $"PRIVATE_KEY_{tokens.UserId}_{exchangeRequest.SenderId}.txt");

        var publicKeyPath = Path.Combine(
            publicKeysDirectory,
            $"PUBLIC_KEY_{tokens.UserId}_{exchangeRequest.SenderId}.txt");

        var commonSecretPath = Path.Combine(
            commonSecretsDirectory,
            $"COMMON_SECRET_{tokens.UserId}_{exchangeRequest.SenderId}.txt");

        privateKeysDirectory.CreateDirectoryIfNotExist();
        publicKeysDirectory.CreateDirectoryIfNotExist();
        commonSecretsDirectory.CreateDirectoryIfNotExist();

        Console.WriteLine(@"Writing private key to file...");
        await File.WriteAllTextAsync(privateKeyPath, privateKeyBase64String);

        Console.WriteLine(@"Writing public key to file ...");
        await File.WriteAllTextAsync(publicKeyPath, publicKeyBase64String);

        Console.WriteLine(@"Writing common secret to file...");
        await File.WriteAllTextAsync(commonSecretPath, commonSecret);

        Console.WriteLine(@"Key exchange request confirmed successfully.");
        Console.WriteLine();
    }

    private async Task<CngGetKeyExchangeRequestByIdResponse> CngGetKeyExchangeById(Guid requestId)
    {
        var result = await HttpRequestHelper.GetAsync(
            client: HttpClient,
            route: $"{CngRoutes.CngKeyExchangeRequests}/{requestId}");

        var response = JsonConvert.DeserializeObject<CngGetKeyExchangeRequestByIdResponse>(result);
        
        return response ?? throw new InvalidOperationException();
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