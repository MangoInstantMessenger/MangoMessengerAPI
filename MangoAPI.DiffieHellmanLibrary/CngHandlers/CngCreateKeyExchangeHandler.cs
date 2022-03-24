using MangoAPI.DiffieHellmanLibrary.Extensions;
using MangoAPI.DiffieHellmanLibrary.Helpers;
using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.CngHandlers;

public class CngCreateKeyExchangeHandler
{
    private readonly CngKeyExchangeService _cngKeyExchangeService;
    private readonly TokensService _tokensService;
    private readonly CngEcdhService _cngEcdhService;

    public CngCreateKeyExchangeHandler(
        CngKeyExchangeService cngKeyExchangeService,
        TokensService tokensService,
        CngEcdhService cngEcdhService)
    {
        _cngKeyExchangeService = cngKeyExchangeService;
        _tokensService = tokensService;
        _cngEcdhService = cngEcdhService;
    }

    public async Task CngRequestKeyExchange(IReadOnlyList<string> args)
    {
        var tokensResponse = await _tokensService.GetTokensAsync();

        var tokens = tokensResponse.Tokens;

        var requestedUserId = Guid.Parse(args[1]);

        _cngEcdhService.CngGenerateEcdhKeysPair(out var privateKeyBase64, out var publicKeyBase64);

        var response = await _cngKeyExchangeService.CngCreateKeyExchangeRequestAsync(requestedUserId, publicKeyBase64);

        Console.WriteLine($"Key exchange request with an ID {response.RequestId} created successfully.");

        var privateKeysDirectory = CngDirectoryHelper.CngPrivateKeysDirectory;
        var publicKeysDirectory = CngDirectoryHelper.CngPublicKeysDirectory;

        var privateKeyPath = Path.Combine(
            privateKeysDirectory, 
            $"PRIVATE_KEY_{tokens.UserId}_{requestedUserId}.txt");

        var publicKeyPath = Path.Combine(
            publicKeysDirectory,
            $"PUBLIC_KEY_{tokens.UserId}_{requestedUserId}.txt");
        
        privateKeysDirectory.CreateDirectoryIfNotExist();
        publicKeysDirectory.CreateDirectoryIfNotExist();

        Console.WriteLine("Writing private key to file...");
        await File.WriteAllTextAsync(privateKeyPath, privateKeyBase64);

        Console.WriteLine("Writing public key to file ...");
        await File.WriteAllTextAsync(publicKeyPath, publicKeyBase64);

        Console.WriteLine("Key exchange request sent successfully.\n");
    }
}