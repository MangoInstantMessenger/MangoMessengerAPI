using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using MangoAPI.DiffieHellmanConsole.Services;
using MangoAPI.Domain.Constants;

namespace MangoAPI.DiffieHellmanConsole.CngHandlers;

public class CngRequestKeyExchangeHandler
{
    private readonly KeyExchangeService _keyExchangeService;
    private readonly TokensService _tokensService;
    private readonly CngEcdhService _cngEcdhService;

    public CngRequestKeyExchangeHandler(
        KeyExchangeService keyExchangeService,
        TokensService tokensService,
        CngEcdhService cngEcdhService)
    {
        _keyExchangeService = keyExchangeService;
        _tokensService = tokensService;
        _cngEcdhService = cngEcdhService;
    }

    public async Task CngRequestKeyExchange(IReadOnlyList<string> args)
    {
        var tokensResponse = await _tokensService.GetTokensAsync();

        if (tokensResponse == null)
        {
            const string error = ResponseMessageCodes.TokensNotFound;
            var details = ResponseMessageCodes.ErrorDictionary[error];
            Console.WriteLine($"{error}. {details}");
            return;
        }

        var tokens = tokensResponse.Tokens;

        var requestedUserId = Guid.Parse(args[1]);

        _cngEcdhService.CngGenerateEcdhKeysPair(out var privateKeyBase64, out var publicKeyBase64);

        var response = await _keyExchangeService.CngCreateKeyExchangeRequestAsync(requestedUserId, publicKeyBase64);

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