using CliWrap;
using MangoAPI.DiffieHellmanLibrary.Abstractions;
using MangoAPI.DiffieHellmanLibrary.Extensions;
using MangoAPI.DiffieHellmanLibrary.Helpers;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpensslGeneratePublicKeyHandler : BaseHandler, IGeneratePublicKeyHandler
{
    public OpensslGeneratePublicKeyHandler(HttpClient httpClient)
        : base(httpClient)
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
        var senderId = TokensResponse.Tokens.UserId;

        var publicKeyFileName = FileNameHelper.GenerateOpenSslPublicKeyFileName(senderId, receiverId);

        var privateKeyFileName = FileNameHelper.GenerateOpenSslPrivateKeyFileName(senderId, receiverId);

        var workingDirectory = OpenSslDirectoryHelper.OpenSslPublicKeysDirectory;

        var publicKeyPath = Path.Combine(workingDirectory, publicKeyFileName);

        var privateKeyPath = Path.Combine(OpenSslDirectoryHelper.OpenSslPrivateKeysDirectory, privateKeyFileName);

        workingDirectory.CreateDirectoryIfNotExist();

        var command = Cli.Wrap("openssl").WithArguments(
            new[] { "pkey", "-in", privateKeyPath, "-pubout", "-out", publicKeyPath });

        _ = await command.ExecuteAsync();
    }
}
