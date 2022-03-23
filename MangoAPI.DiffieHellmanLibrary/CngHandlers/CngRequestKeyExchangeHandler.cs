using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.CngHandlers;

public class CngRequestKeyExchangeHandler
{
    private readonly CngKeyExchangeService _cngKeyExchangeService;
    private readonly TokensService _tokensService;
    private readonly CngEcdhService _cngEcdhService;

    public CngRequestKeyExchangeHandler(
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

        var keysFolderPath = Path.Combine(AppContext.BaseDirectory, $"Keys_{tokens.UserId}");

        var privateKeyPath =
            Path.Combine(keysFolderPath, $"PrivateKey_{tokens.UserId}_{requestedUserId}.txt");

        var publicKeyPath = Path.Combine(keysFolderPath,
            $"PublicKey_{tokens.UserId}_{requestedUserId}.txt");

        if (!Directory.Exists(keysFolderPath))
        {
            Directory.CreateDirectory(keysFolderPath);
        }

        Console.WriteLine("Writing private key to file...");
        await File.WriteAllTextAsync(privateKeyPath, privateKeyBase64);

        Console.WriteLine("Writing public key to file ...");
        await File.WriteAllTextAsync(publicKeyPath, publicKeyBase64);

        Console.WriteLine("Key exchange request sent successfully.\n");
    }
}