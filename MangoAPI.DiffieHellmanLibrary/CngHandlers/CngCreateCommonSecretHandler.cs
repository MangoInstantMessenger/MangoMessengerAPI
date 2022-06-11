using System.Security.Cryptography;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.DiffieHellmanLibrary.Abstractions;
using MangoAPI.DiffieHellmanLibrary.Extensions;
using MangoAPI.DiffieHellmanLibrary.Helpers;

namespace MangoAPI.DiffieHellmanLibrary.CngHandlers;

public class CngCreateCommonSecretHandler : BaseHandler, ICreateCommonSecretHandler
{
    public CngCreateCommonSecretHandler(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task CreateCommonSecretAsync(Actor actor, Guid userId)
    {
        throw new NotImplementedException();
    }

    private async Task CngCreateCommonSecret(IReadOnlyList<string> args)
    {
        var tokens = TokensResponse.Tokens;

        var partnerId = Guid.Parse(args[1]);

        var response = await CngGetPublicKeys();

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

        var privateKey = CngKey.Import(privateKeyBytes, CngKeyBlobFormat.EccPrivateBlob);

        var ecDiffieHellmanCng = new ECDiffieHellmanCng(privateKey);

        var partnerPublicKey = CngKey.Import(partnerPublicKeyBytes!, CngKeyBlobFormat.EccPublicBlob);

        var commonSecretBase64 = ecDiffieHellmanCng.DeriveKeyMaterial(partnerPublicKey).AsBase64String();

        Console.WriteLine(@"Writing common secret to file...");
        await File.WriteAllTextAsync(commonSecretPath, commonSecretBase64);

        Console.WriteLine(@"Common secret generated successfully.
");
    }
}