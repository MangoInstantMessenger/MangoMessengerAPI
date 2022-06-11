using CliWrap;
using MangoAPI.DiffieHellmanLibrary.Abstractions;
using MangoAPI.DiffieHellmanLibrary.Extensions;
using MangoAPI.DiffieHellmanLibrary.Helpers;
using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class GeneratePrivateKeyHandler : BaseHandler, IGeneratePrivateKeyHandler
{
    public GeneratePrivateKeyHandler(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task GeneratePrivateKeyAsync(Guid receiverId)
    {
        Console.WriteLine($@"Generating private key of the user {receiverId}...");

        await OpenSslGeneratePrivateKeyAsync(receiverId);

        Console.WriteLine($@"Private key of the user {receiverId} has been generated successfully.");

        Console.WriteLine();
    }

    private async Task OpenSslGeneratePrivateKeyAsync(Guid receiverId)
    {
        var tokensResponse = await TokensService.GetTokensAsync();

        var senderId = tokensResponse.Tokens.UserId;

        var privateKeyFileName = FileNameHelper.GeneratePrivateKeyFileName(senderId, receiverId);

        var workingDirectory = OpenSslDirectoryHelper.OpenSslPrivateKeysDirectory;

        var privateKeyPath = Path.Combine(workingDirectory, privateKeyFileName);

        workingDirectory.CreateDirectoryIfNotExist();

        var dhParametersPath = Path.Combine(
            OpenSslDirectoryHelper.OpenSslDhParametersDirectory,
            FileNameHelper.DownloadedParametersFileName);

        var command = Cli.Wrap("openssl").WithArguments(
            new[] { "genpkey", "-paramfile", dhParametersPath, "-out", privateKeyPath });

        await command.ExecuteAsync();
    }
}