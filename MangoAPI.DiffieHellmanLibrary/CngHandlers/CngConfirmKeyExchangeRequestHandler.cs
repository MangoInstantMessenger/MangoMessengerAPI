using System.Security.Cryptography;
using MangoAPI.DiffieHellmanLibrary.Extensions;
using MangoAPI.DiffieHellmanLibrary.Services;
using MangoAPI.Domain.Constants;

namespace MangoAPI.DiffieHellmanLibrary.CngHandlers;

public class CngConfirmKeyExchangeRequestHandler
{
    private readonly CngKeyExchangeService _cngKeyExchangeService;
    private readonly CngEcdhService _cngEcdhService;
    private readonly TokensService _tokensService;

    public CngConfirmKeyExchangeRequestHandler(
        CngKeyExchangeService cngKeyExchangeService,
        CngEcdhService cngEcdhService,
        TokensService tokensService)
    {
        _cngKeyExchangeService = cngKeyExchangeService;
        _cngEcdhService = cngEcdhService;
        _tokensService = tokensService;
    }

    public async Task CngConfirmKeyExchangeRequest(IReadOnlyList<string> args)
    {
        var tokensResponse = await _tokensService.GetTokensAsync();

        var tokens = tokensResponse.Tokens;

        var requestId = Guid.Parse(args[1]);

        var getKeyExchangeResponse = await _cngKeyExchangeService.CngGetKeyExchangesAsync();

        var exchangeRequest = getKeyExchangeResponse.KeyExchangeRequests
            .FirstOrDefault(x => x.RequestId == requestId);

        if (exchangeRequest == null)
        {
            const string error = ResponseMessageCodes.KeyExchangeRequestNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[error];
            Console.WriteLine($"{error}. {details}");
            return;
        }

        var ecDiffieHellmanCng = _cngEcdhService.CngGenerateEcdhKeysPair(
            out var privateKeyBase64String,
            out var publicKeyBase64String);

        var requestPublicKeyBytes = exchangeRequest.SenderPublicKey.Base64StringAsBytes();

#pragma warning disable CA1416
        var requestPublicKey = CngKey.Import(requestPublicKeyBytes, CngKeyBlobFormat.EccPublicBlob);
#pragma warning restore CA1416

#pragma warning disable CA1416
        var commonSecret = ecDiffieHellmanCng.DeriveKeyMaterial(requestPublicKey).AsBase64String();
#pragma warning restore CA1416

        await _cngKeyExchangeService.CngConfirmOrDeclineKeyExchangeAsync(requestId, publicKeyBase64String);

        var keysFolderPath = Path.Combine(AppContext.BaseDirectory, $"Keys_{tokens.UserId}");

        var privateKeyPath = Path.Combine(
            keysFolderPath,
            $"PrivateKey_{tokens.UserId}_{exchangeRequest.SenderId}.txt");

        var publicKeyPath = Path.Combine(
            keysFolderPath,
            $"PublicKey_{tokens.UserId}_{exchangeRequest.SenderId}.txt");

        var commonSecretPath = Path.Combine(
            keysFolderPath,
            $"CommonSecret_{tokens.UserId}_{exchangeRequest.SenderId}.txt");

        if (!Directory.Exists(keysFolderPath))
        {
            Directory.CreateDirectory(keysFolderPath);
        }

        Console.WriteLine("Writing private key to file...");
        await File.WriteAllTextAsync(privateKeyPath, privateKeyBase64String);

        Console.WriteLine("Writing public key to file ...");
        await File.WriteAllTextAsync(publicKeyPath, publicKeyBase64String);

        Console.WriteLine("Writing common secret to file...");
        await File.WriteAllTextAsync(commonSecretPath, commonSecret);

        Console.WriteLine("Key exchange request confirmed successfully.\n");
    }
}