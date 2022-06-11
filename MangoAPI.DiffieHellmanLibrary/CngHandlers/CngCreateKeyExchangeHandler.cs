using MangoAPI.DiffieHellmanLibrary.Abstractions;
using MangoAPI.DiffieHellmanLibrary.Extensions;
using MangoAPI.DiffieHellmanLibrary.Helpers;
using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.CngHandlers;

public class CngCreateKeyExchangeHandler : ICreateKeyExchangeHandler
{
    private readonly CngKeyExchangeService _cngKeyExchangeService;

    public CngCreateKeyExchangeHandler(CngKeyExchangeService cngKeyExchangeService)
    {
        _cngKeyExchangeService = cngKeyExchangeService;
    }

    public async Task CreateKeyExchangeAsync(Guid receiverId)
    {
        await CngRequestKeyExchange(receiverId);
    }

    private async Task CngRequestKeyExchange(Guid receiverId)
    {
        var tokensResponse = await TokensService.GetTokensAsync();

        var tokens = tokensResponse.Tokens;

        CngEcdhService.CngGenerateEcdhKeysPair(out var privateKeyBase64, out var publicKeyBase64);

        var response = await _cngKeyExchangeService.CngCreateKeyExchangeRequestAsync(receiverId, publicKeyBase64);

        Console.WriteLine($@"Key exchange request with an ID {response.RequestId} created successfully.");

        var privateKeysDirectory = CngDirectoryHelper.CngPrivateKeysDirectory;
        var publicKeysDirectory = CngDirectoryHelper.CngPublicKeysDirectory;

        var privateKeyPath = Path.Combine(
            privateKeysDirectory,
            $"PRIVATE_KEY_{tokens.UserId}_{receiverId}.txt");

        var publicKeyPath = Path.Combine(
            publicKeysDirectory,
            $"PUBLIC_KEY_{tokens.UserId}_{receiverId}.txt");

        privateKeysDirectory.CreateDirectoryIfNotExist();
        publicKeysDirectory.CreateDirectoryIfNotExist();

        Console.WriteLine(@"Writing private key to file...");
        await File.WriteAllTextAsync(privateKeyPath, privateKeyBase64);

        Console.WriteLine(@"Writing public key to file ...");
        await File.WriteAllTextAsync(publicKeyPath, publicKeyBase64);

        Console.WriteLine(@"Key exchange request sent successfully.");
        Console.WriteLine();
    }
}