using CliWrap;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.DiffieHellmanLibrary.Abstractions;
using MangoAPI.DiffieHellmanLibrary.Extensions;
using MangoAPI.DiffieHellmanLibrary.Helpers;
using MangoAPI.Domain.Enums;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpensslCreateCommonSecretHandler : BaseHandler, ICreateCommonSecretHandler
{
    public OpensslCreateCommonSecretHandler(HttpClient httpClient) : base(httpClient)
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
        var allKeyExchanges = await GetKeyExchangesAsync();

        var tokens = TokensResponse.Tokens;
        var currentUserId = tokens.UserId;

        OpenSslKeyExchangeRequest keyExchangeRequest;

        if (actor == Actor.Receiver)
        {
            keyExchangeRequest = allKeyExchanges.FirstOrDefault(x =>
                x.SenderId == partnerId &&
                x.ReceiverId == currentUserId &&
                x.KeyExchangeType == KeyExchangeType.OpenSsl);
        }
        else
        {
            keyExchangeRequest = allKeyExchanges.FirstOrDefault(x =>
                x.SenderId == currentUserId &&
                x.ReceiverId == partnerId &&
                x.KeyExchangeType == KeyExchangeType.OpenSsl);
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

        var publicKeyFileName = FileNameHelper.GenerateOpenSslPublicKeyFileName(currentUserId, requestId);
        var privateKeyFileName = FileNameHelper.GenerateOpenSslPrivateKeyFileName(currentUserId, receiverId);
        var commonSecretFileName = FileNameHelper.GenerateOpensslCommonSecretFileName(currentUserId, receiverId);

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