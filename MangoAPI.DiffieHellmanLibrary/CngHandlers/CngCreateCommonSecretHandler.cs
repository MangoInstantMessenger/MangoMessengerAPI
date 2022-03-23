using System.Security.Cryptography;
using MangoAPI.DiffieHellmanLibrary.Extensions;
using MangoAPI.DiffieHellmanLibrary.Helpers;
using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.CngHandlers;

public class CngCreateCommonSecretHandler
{
    private readonly CngPublicKeysService _cngPublicKeysService;
    private readonly TokensService _tokensService;

    public CngCreateCommonSecretHandler(CngPublicKeysService cngPublicKeysService, TokensService tokensService)
    {
        _cngPublicKeysService = cngPublicKeysService;
        _tokensService = tokensService;
    }

    public async Task CngCreateCommonSecret(IReadOnlyList<string> args)
    {
        var tokensResponse = await _tokensService.GetTokensAsync();

        var tokens = tokensResponse.Tokens;

        var partnerId = Guid.Parse(args[1]);

        var response = await _cngPublicKeysService.CngGetPublicKeys();

        var partnerPublicKeyBytes = response.PublicKeys
            .FirstOrDefault(x => x.PartnerId == partnerId)?
            .PartnerPublicKey.Base64StringAsBytes();

        var privateKeyPath = Path.Combine(
            CngDirectoryHelper.CngPrivateKeysDirectory,
            $"PRIVATE_KEY_{tokens.UserId}_{partnerId}.txt");

        var commonSecretPath = Path.Combine(
            CngDirectoryHelper.CngCommonSecretsDirectory,
            $"COMMON_SECRET_{tokens.UserId}_{partnerId}.txt");

        var privateKeyBytes = (await File.ReadAllTextAsync(privateKeyPath)).Base64StringAsBytes();

#pragma warning disable CA1416
        var privateKey = CngKey.Import(privateKeyBytes, CngKeyBlobFormat.EccPrivateBlob);
#pragma warning restore CA1416

#pragma warning disable CA1416
        var ecDiffieHellmanCng = new ECDiffieHellmanCng(privateKey);
#pragma warning restore CA1416

#pragma warning disable CA1416
        var partnerPublicKey = CngKey.Import(partnerPublicKeyBytes!, CngKeyBlobFormat.EccPublicBlob);
#pragma warning restore CA1416

#pragma warning disable CA1416
        var commonSecretBase64 = ecDiffieHellmanCng.DeriveKeyMaterial(partnerPublicKey).AsBase64String();
#pragma warning restore CA1416

        Console.WriteLine("Writing common secret to file...");
        await File.WriteAllTextAsync(commonSecretPath, commonSecretBase64);

        Console.WriteLine("Common secret generated successfully.\n");
    }
}