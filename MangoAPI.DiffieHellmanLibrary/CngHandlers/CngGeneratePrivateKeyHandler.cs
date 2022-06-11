using MangoAPI.DiffieHellmanLibrary.Abstractions;
using MangoAPI.DiffieHellmanLibrary.Extensions;
using MangoAPI.DiffieHellmanLibrary.Helpers;

namespace MangoAPI.DiffieHellmanLibrary.CngHandlers;

public class CngGeneratePrivateKeyHandler : BaseHandler, IGeneratePrivateKeyHandler
{
    public CngGeneratePrivateKeyHandler(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task GeneratePrivateKeyAsync(Guid receiverId)
    {
        Console.WriteLine(@$"Generating CNG private key for user {receiverId} ... ");
        
        await GenerateBase64PrivateKey(receiverId);
        
        Console.WriteLine(@"Private key has been generated successfully.");
        Console.WriteLine();
    }

    private async Task GenerateBase64PrivateKey(Guid receiverId)
    {
        var senderId = TokensResponse.Tokens.UserId;
        var privateKeyFolder = CngDirectoryHelper.CngPrivateKeysDirectory;
        var privateKeyFileName = FileNameHelper.GenerateCngPrivateKeyFileName(senderId, receiverId);
        var privateKeyPath = Path.Combine(privateKeyFolder, privateKeyFileName);

        var privateKeyBase64String = CngEcdhHelper.GenerateEcdhBase64StringPrivateKey();

        privateKeyFolder.CreateDirectoryIfNotExist();

        await File.WriteAllTextAsync(privateKeyPath, privateKeyBase64String);
    }
}