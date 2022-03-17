using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using MangoAPI.DiffieHellmanConsole.Extensions;
using MangoAPI.DiffieHellmanConsole.Services;
using MangoAPI.Domain.Constants;

namespace MangoAPI.DiffieHellmanConsole.CngHandlers;

public class CngCreateCommonSecretHandler
{
    private readonly PublicKeysService _publicKeysService;
    private readonly TokensService _tokensService;

    public CngCreateCommonSecretHandler(PublicKeysService publicKeysService, TokensService tokensService)
    {
        _publicKeysService = publicKeysService;
        _tokensService = tokensService;
    }

    public async Task CreateCommonSecret(IReadOnlyList<string> args)
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

        var partnerId = Guid.Parse(args[1]);

        var response = await _publicKeysService.GetPublicKeys();

        var partnerPublicKeyBytes = response.PublicKeys
            .FirstOrDefault(x => x.PartnerId == partnerId)?
            .PartnerPublicKey.Base64StringAsBytes();

        var privateKeyPath = Path.Combine(
            AppContext.BaseDirectory,
            $"Keys_{tokens.UserId}",
            $"PrivateKey_{tokens.UserId}_{partnerId}.txt");

        var commonSecretPath = Path.Combine(
            AppContext.BaseDirectory,
            $"Keys_{tokens.UserId}",
            $"CommonSecret_{tokens.UserId}_{partnerId}.txt");

        var privateKeyBytes = (await File.ReadAllTextAsync(privateKeyPath)).Base64StringAsBytes();

        var privateKey = CngKey.Import(privateKeyBytes, CngKeyBlobFormat.EccPrivateBlob);

        var ecDiffieHellmanCng = new ECDiffieHellmanCng(privateKey);

        var partnerPublicKey = CngKey.Import(partnerPublicKeyBytes!, CngKeyBlobFormat.EccPublicBlob);

        var commonSecretBase64 = ecDiffieHellmanCng.DeriveKeyMaterial(partnerPublicKey).AsBase64String();

        Console.WriteLine("Writing common secret to file...");
        await File.WriteAllTextAsync(commonSecretPath, commonSecretBase64);

        Console.WriteLine("Common secret generated successfully.\n");
    }
}