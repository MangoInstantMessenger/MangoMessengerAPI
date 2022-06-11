using CliWrap;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.DiffieHellmanLibrary.Extensions;
using MangoAPI.DiffieHellmanLibrary.Helpers;
using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpenSslCreateCommonSecretHandler : BaseHandler
{
    public OpenSslCreateCommonSecretHandler(HttpClient httpClient, TokensService tokensService) : base(httpClient,
        tokensService)
    {
    }

    public async Task CreateCommonSecretAsync(Actor actor, Guid userId)
    {
        Console.WriteLine($@"Creating common secret with the user {userId} ...");

        await OpensslCreateCommonSecretAsync(actor, userId);

        Console.WriteLine($@"Common secret with the user {userId} has been successfully created.");
        Console.WriteLine();
    }

    private async Task OpensslCreateCommonSecretAsync(Actor actor, Guid partnerId)
    {
        var allKeyExchanges = await OpensslGetKeyExchangesAsync();

        var tokensResponse = await TokensService.GetTokensAsync();
        var tokens = tokensResponse.Tokens;
        var currentUserId = tokens.UserId;

        OpenSslKeyExchangeRequest keyExchangeRequest;

        if (actor == Actor.Receiver)
        {
            keyExchangeRequest = allKeyExchanges.FirstOrDefault(x =>
                x.SenderId == partnerId && x.ReceiverId == currentUserId);
        }
        else
        {
            keyExchangeRequest = allKeyExchanges.FirstOrDefault(x =>
                x.SenderId == currentUserId && x.ReceiverId == partnerId);
        }

        if (keyExchangeRequest == null)
        {
            throw new InvalidOperationException();
        }

        var requestId = keyExchangeRequest.RequestId;

        var receiverId = keyExchangeRequest.Actor == Actor.Receiver
            ? keyExchangeRequest.SenderId
            : keyExchangeRequest.ReceiverId;

        var publicKeyDirectory = OpenSslDirectoryHelper.OpenSslPublicKeysDirectory;
        var privateKeyDirectory = OpenSslDirectoryHelper.OpenSslPrivateKeysDirectory;
        var commonSecretDirectory = OpenSslDirectoryHelper.OpenSslCommonSecretsDirectory;

        var publicKeyFileName = FileNameHelper.GeneratePublicKeyFileName(currentUserId, requestId);
        var privateKeyFileName = FileNameHelper.GeneratePrivateKeyFileName(currentUserId, receiverId);
        var commonSecretFileName = FileNameHelper.GenerateCommonSecretFileName(currentUserId, receiverId);

        commonSecretDirectory.CreateDirectoryIfNotExist();

        var publicKeyPath = Path.Combine(publicKeyDirectory, publicKeyFileName);
        var privateKeyPath = Path.Combine(privateKeyDirectory, privateKeyFileName);
        var commonSecretPath = Path.Combine(commonSecretDirectory, commonSecretFileName);

        var command = Cli.Wrap("openssl").WithArguments(
            new[]
            {
                "pkeyutl", "-derive", "-inkey", privateKeyPath, "-peerkey", publicKeyPath, "-out", commonSecretPath
            });

        await command.ExecuteAsync();
    }
}