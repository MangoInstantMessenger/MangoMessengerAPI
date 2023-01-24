using System.Security.Cryptography;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.DiffieHellmanLibrary.Abstractions;
using MangoAPI.DiffieHellmanLibrary.Extensions;
using MangoAPI.DiffieHellmanLibrary.Helpers;
using MangoAPI.Domain.Enums;

namespace MangoAPI.DiffieHellmanLibrary.CngHandlers;

public class CngCreateCommonSecretHandler : BaseHandler, ICreateCommonSecretHandler
{
    public CngCreateCommonSecretHandler(HttpClient httpClient)
        : base(httpClient)
    {
    }

    public async Task CreateCommonSecretAsync(Actor actor, Guid userId)
    {
        Console.WriteLine($@"Creating common secret with the user {userId} ...");

        await CngCreateCommonSecretAsync(actor, userId);

        Console.WriteLine($@"Common secret with the user {userId} has been successfully created.");
        Console.WriteLine();
    }

    private async Task CngCreateCommonSecretAsync(Actor actor, Guid partnerId)
    {
        var allKeyExchanges = await GetKeyExchangesAsync();

        var tokens = TokensResponse.Tokens;
        var currentUserId = tokens.UserId;

        var keyExchangeRequest = actor == Actor.Receiver
            ? allKeyExchanges.FirstOrDefault(x =>
                x.SenderId == partnerId &&
                x.ReceiverId == currentUserId &&
                x.KeyExchangeType == KeyExchangeType.Cng)
            : allKeyExchanges.FirstOrDefault(x =>
                x.SenderId == currentUserId &&
                x.ReceiverId == partnerId &&
                x.KeyExchangeType == KeyExchangeType.Cng);
        if (keyExchangeRequest == null)
        {
            throw new InvalidOperationException();
        }

        var requestId = keyExchangeRequest.RequestId;

        var receiverId = keyExchangeRequest.Actor == Actor.Receiver
            ? keyExchangeRequest.SenderId
            : keyExchangeRequest.ReceiverId;

        var publicKeyDirectory = CngDirectoryHelper.CngPublicKeysDirectory;
        var privateKeyDirectory = CngDirectoryHelper.CngPrivateKeysDirectory;
        var commonSecretDirectory = CngDirectoryHelper.CngCommonSecretsDirectory;

        var publicKeyFileName = FileNameHelper.GenerateCngPublicKeyFileName(currentUserId, requestId);
        var privateKeyFileName = FileNameHelper.GenerateCngPrivateKeyFileName(currentUserId, receiverId);
        var commonSecretFileName = FileNameHelper.GenerateCngCommonSecretFileName(currentUserId, receiverId);

        commonSecretDirectory.CreateDirectoryIfNotExist();

        var publicKeyPath = Path.Combine(publicKeyDirectory, publicKeyFileName);
        var privateKeyPath = Path.Combine(privateKeyDirectory, privateKeyFileName);
        var commonSecretPath = Path.Combine(commonSecretDirectory, commonSecretFileName);

        var privateKeyBase64 = await File.ReadAllTextAsync(privateKeyPath);
        var privateKeyBytes = privateKeyBase64.Base64StringAsBytes();
        var privateKey = CngKey.Import(privateKeyBytes, CngKeyBlobFormat.EccPrivateBlob);
        var ecDiffieHellmanCng = new ECDiffieHellmanCng(privateKey);

        var partnerKeyBase64 = await File.ReadAllTextAsync(publicKeyPath);
        var partnerPublicKeyBytes = partnerKeyBase64.Base64StringAsBytes();
        var partnerPublicKey = CngKey.Import(partnerPublicKeyBytes, CngKeyBlobFormat.EccPublicBlob);
        var commonSecretBase64 = ecDiffieHellmanCng.DeriveKeyMaterial(partnerPublicKey).AsBase64String();

        await File.WriteAllTextAsync(commonSecretPath, commonSecretBase64);
    }
}
