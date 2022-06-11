using System.Security.Cryptography;
using MangoAPI.DiffieHellmanLibrary.Extensions;
using MangoAPI.DiffieHellmanLibrary.Helpers;
using MangoAPI.DiffieHellmanLibrary.Services;

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

    public async Task CngConfirmKeyExchangeRequest(Guid requestId)
    {
        var tokensResponse = await _tokensService.GetTokensAsync();

        var tokens = tokensResponse.Tokens;

        var getKeyExchangeResponse = await _cngKeyExchangeService.CngGetKeyExchangeById(requestId);
        var exchangeRequest = getKeyExchangeResponse.KeyExchangeRequest;

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

        Console.WriteLine(@"Key exchange request confirmed successfully.
");
    }
}