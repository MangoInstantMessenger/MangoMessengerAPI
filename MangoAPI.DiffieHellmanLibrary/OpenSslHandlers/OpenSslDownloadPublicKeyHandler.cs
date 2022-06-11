using MangoAPI.BusinessLogic.Models;
using MangoAPI.DiffieHellmanLibrary.Constants;
using MangoAPI.DiffieHellmanLibrary.Extensions;
using MangoAPI.DiffieHellmanLibrary.Helpers;
using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpenSslDownloadPublicKeyHandler : BaseHandler
{
    public OpenSslDownloadPublicKeyHandler(HttpClient httpClient, TokensService tokensService) : base(httpClient,
        tokensService)
    {
    }

    public async Task DownloadPublicKeyAsync(Actor actor, Guid userId)
    {
        Console.WriteLine($@"Downloading public key of the user {userId} ...");

        await OpensslDownloadPublicKeyAsync(actor, userId);

        Console.WriteLine($@"Public key of the user {userId} has been downloaded successfully.");

        Console.WriteLine();
    }

    private async Task OpensslDownloadPublicKeyAsync(Actor actor, Guid userId)
    {
        var tokensResponse = await TokensService.GetTokensAsync();
        var currentUserId = tokensResponse.Tokens.UserId;

        var allRequests = await OpensslGetKeyExchangesAsync();

        OpenSslKeyExchangeRequest keyExchangeRequest;

        if (actor == Actor.Receiver)
        {
            keyExchangeRequest = allRequests.FirstOrDefault(request =>
                request.SenderId == userId && request.ReceiverId == currentUserId);
        }
        else
        {
            keyExchangeRequest = allRequests.FirstOrDefault(request =>
                request.ReceiverId == userId && request.SenderId == currentUserId);
        }

        if (keyExchangeRequest == null)
        {
            throw new InvalidOperationException();
        }

        var address = $"{OpenSslRoutes.OpenSslPublicKeys}/{keyExchangeRequest.RequestId}";
        var uri = new Uri(address, UriKind.Absolute);

        var response = await HttpClient.GetAsync(uri);
        response.EnsureSuccessStatusCode();

        await using var stream = await response.Content.ReadAsStreamAsync();

        var workingDirectory = OpenSslDirectoryHelper.OpenSslPublicKeysDirectory;

        var publicKeyFileName = FileNameHelper.GeneratePublicKeyFileName(
            currentUserId,
            keyExchangeRequest.RequestId);

        var filePath = Path.Combine(workingDirectory, publicKeyFileName);

        workingDirectory.CreateDirectoryIfNotExist();

        var fileInfo = new FileInfo(filePath);

        await using var fileStream = fileInfo.OpenWrite();

        await stream.CopyToAsync(fileStream);
    }
}