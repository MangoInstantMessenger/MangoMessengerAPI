using CliWrap;
using MangoAPI.DiffieHellmanLibrary.Extensions;
using MangoAPI.DiffieHellmanLibrary.Helpers;
using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpenSslGeneratePublicKeyHandler : BaseHandler
{
    public OpenSslGeneratePublicKeyHandler(HttpClient httpClient, TokensService tokensService) : base(httpClient,
        tokensService)
    {
    }

    public async Task GeneratePublicKeyAsync(Guid receiverId)
    {
        Console.WriteLine($@"Generating public key of the user {receiverId} ...");

        await OpenSslGeneratePublicKeyAsync(receiverId);

        Console.WriteLine($@"Public key of the user {receiverId} has been generated successfully.");

        Console.WriteLine();
    }

    private async Task OpenSslGeneratePublicKeyAsync(Guid receiverId)
    {
        var tokensResponse = await TokensService.GetTokensAsync();

        var senderId = tokensResponse.Tokens.UserId;

        var publicKeyFileName = FileNameHelper.GeneratePublicKeyFileName(senderId, receiverId);

        var privateKeyFileName = FileNameHelper.GeneratePrivateKeyFileName(senderId, receiverId);

        var workingDirectory = OpenSslDirectoryHelper.OpenSslPublicKeysDirectory;

        var publicKeyPath = Path.Combine(workingDirectory, publicKeyFileName);

        var privateKeyPath = Path.Combine(OpenSslDirectoryHelper.OpenSslPrivateKeysDirectory, privateKeyFileName);

        workingDirectory.CreateDirectoryIfNotExist();

        var command = Cli.Wrap("openssl").WithArguments(
            new[] { "pkey", "-in", privateKeyPath, "-pubout", "-out", publicKeyPath });

        await command.ExecuteAsync();
    }
}