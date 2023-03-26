using System.Security.Cryptography;
using MangoAPI.DiffieHellmanLibrary.Abstractions;
using MangoAPI.DiffieHellmanLibrary.Extensions;
using MangoAPI.DiffieHellmanLibrary.Helpers;

namespace MangoAPI.DiffieHellmanLibrary.CngHandlers;

public class CngGeneratePublicKeyHandler : BaseHandler, IGeneratePublicKeyHandler
{
    public CngGeneratePublicKeyHandler(HttpClient httpClient)
        : base(httpClient)
    {
    }

    public async Task GeneratePublicKeyAsync(Guid receiverId)
    {
        Console.WriteLine($@"Generating public key for user the user {receiverId} ...");

        await GenerateBase64PublicKeyAsync(receiverId);

        Console.WriteLine($@"Public key for user {receiverId} generated successfully.");
        Console.WriteLine();
    }

    private async Task GenerateBase64PublicKeyAsync(Guid receiverId)
    {
        var senderId = TokensResponse.Tokens.UserId;
        var privateKeyFolder = CngDirectoryHelper.CngPrivateKeysDirectory;
        var privateKeyFileName = FileNameHelper.GenerateCngPrivateKeyFileName(senderId, receiverId);
        var privateKeyPath = Path.Combine(privateKeyFolder, privateKeyFileName);

        var privateKeyText = await File.ReadAllTextAsync(privateKeyPath);
        var privateKeyBytes = privateKeyText.Base64StringAsBytes();

        var privateKey = CngKey.Import(privateKeyBytes, CngKeyBlobFormat.EccPrivateBlob);

        var ecDiffieHellmanCng = new ECDiffieHellmanCng(privateKey);

        var publicKey = ecDiffieHellmanCng.PublicKey.ToByteArray().AsBase64String();

        var publicKeyFolder = CngDirectoryHelper.CngPublicKeysDirectory;
        var publicKeyFileName = FileNameHelper.GenerateCngPublicKeyFileName(senderId, receiverId);
        var publicKeyPath = Path.Combine(publicKeyFolder, publicKeyFileName);

        publicKeyFolder.CreateDirectoryIfNotExist();

        await File.WriteAllTextAsync(publicKeyPath, publicKey);
    }
}