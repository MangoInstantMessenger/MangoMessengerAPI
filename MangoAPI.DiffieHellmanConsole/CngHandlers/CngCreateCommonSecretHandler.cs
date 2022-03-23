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
    private readonly CngPublicKeysService _cngPublicKeysService;
    private readonly TokensService _tokensService;

    public CngCreateCommonSecretHandler(CngPublicKeysService cngPublicKeysService, TokensService tokensService)
    {
        _cngPublicKeysService = cngPublicKeysService;
        _tokensService = tokensService;
    }

    public async Task CngCreateCommonSecret(IReadOnlyList<string> args)
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

        var response = await _cngPublicKeysService.CngGetPublicKeys();

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