using MangoAPI.DiffieHellmanLibrary.Abstractions;
using MangoAPI.DiffieHellmanLibrary.Extensions;
using MangoAPI.DiffieHellmanLibrary.Helpers;

namespace MangoAPI.DiffieHellmanLibrary.CngHandlers;

public class CngGeneratePrivateKeyHandler : BaseHandler, IGeneratePrivateKeyHandler
{
    public CngGeneratePrivateKeyHandler(HttpClient httpClient)
        : base(httpClient)
    {
    }

    public async Task GeneratePrivateKeyAsync(Guid receiverId)
    {
        Console.WriteLine(@$"Generating CNG private key for user {receiverId} ... ");

        await GenerateBase64PrivateKeyAsync(receiverId);

        Console.WriteLine(@"Private key has been generated successfully.");
        Console.WriteLine();
    }

    private async Task GenerateBase64PrivateKeyAsync(Guid receiverId)
    {
        var senderId = TokensResponse.Tokens.UserId;
        var privateKeyFolder = CngDirectoryHelper.CngPrivateKeysDirectory;
        var privateKeyFileName = FileNameHelper.GenerateCngPrivateKeyFileName(senderId, receiverId);
        var privateKeyPath = Path.Combine(privateKeyFolder, privateKeyFileName);

        var publicKeyFolder = CngDirectoryHelper.CngPublicKeysDirectory;
        var publicKeyFileName = FileNameHelper.GenerateCngPublicKeyFileName(senderId, receiverId);
        var publicKeyPath = Path.Combine(publicKeyFolder, publicKeyFileName);

        var keyPair = CngEcdhHelper.GenerateEcdhBase64StringPrivateKey();

        privateKeyFolder.CreateDirectoryIfNotExist();
        publicKeyFolder.CreateDirectoryIfNotExist();

        await File.WriteAllTextAsync(privateKeyPath, keyPair.PrivateKey);
        await File.WriteAllTextAsync(publicKeyPath, keyPair.PublicKey);
    }
}
