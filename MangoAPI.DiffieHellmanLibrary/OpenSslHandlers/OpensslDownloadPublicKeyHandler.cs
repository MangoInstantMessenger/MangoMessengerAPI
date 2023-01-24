using MangoAPI.BusinessLogic.Models;
using MangoAPI.DiffieHellmanLibrary.Abstractions;
using MangoAPI.DiffieHellmanLibrary.Constants;
using MangoAPI.DiffieHellmanLibrary.Extensions;
using MangoAPI.DiffieHellmanLibrary.Helpers;
using MangoAPI.Domain.Enums;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpensslDownloadPublicKeyHandler : BaseHandler, IDownloadPublicKeyHandler
{
    public OpensslDownloadPublicKeyHandler(HttpClient httpClient)
        : base(httpClient)
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
        var currentUserId = TokensResponse.Tokens.UserId;

        var allRequests = await GetKeyExchangesAsync();

        var keyExchangeRequest = actor == Actor.Receiver
            ? allRequests.FirstOrDefault(request =>
                request.SenderId == userId && request.ReceiverId == currentUserId &&
                request.IsConfirmed &&
                request.KeyExchangeType == KeyExchangeType.OpenSsl)
            : allRequests.FirstOrDefault(request =>
                request.ReceiverId == userId &&
                request.SenderId == currentUserId &&
                request.IsConfirmed &&
                request.KeyExchangeType == KeyExchangeType.OpenSsl);
        if (keyExchangeRequest == null)
        {
            throw new InvalidOperationException();
        }

        var address = $"{KeyExchangeRoutes.PublicKeys}/{keyExchangeRequest.RequestId}";
        var uri = new Uri(address, UriKind.Absolute);

        var response = await HttpClient.GetAsync(uri);
        response.EnsureSuccessStatusCode();

        await using var stream = await response.Content.ReadAsStreamAsync();

        var workingDirectory = OpenSslDirectoryHelper.OpenSslPublicKeysDirectory;

        var publicKeyFileName = FileNameHelper.GenerateOpenSslPublicKeyFileName(
            currentUserId,
            keyExchangeRequest.RequestId);

        var filePath = Path.Combine(workingDirectory, publicKeyFileName);

        workingDirectory.CreateDirectoryIfNotExist();

        var fileInfo = new FileInfo(filePath);

        await using var fileStream = fileInfo.OpenWrite();

        await stream.CopyToAsync(fileStream);
    }
}
