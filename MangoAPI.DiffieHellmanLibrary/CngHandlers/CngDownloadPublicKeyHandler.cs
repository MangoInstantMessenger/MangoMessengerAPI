using MangoAPI.BusinessLogic.Models;
using MangoAPI.DiffieHellmanLibrary.Abstractions;
using MangoAPI.DiffieHellmanLibrary.Constants;
using MangoAPI.DiffieHellmanLibrary.Extensions;
using MangoAPI.DiffieHellmanLibrary.Helpers;
using MangoAPI.Domain.Enums;

namespace MangoAPI.DiffieHellmanLibrary.CngHandlers;

public class CngDownloadPublicKeyHandler : BaseHandler, IDownloadPublicKeyHandler
{
    public CngDownloadPublicKeyHandler(HttpClient httpClient)
        : base(httpClient)
    {
    }

    public async Task DownloadPublicKeyAsync(Actor actor, Guid userId)
    {
        Console.WriteLine($@"Downloading public key of the user {userId} ...");

        await CngDownloadPublicKeyAsync(actor, userId);

        Console.WriteLine($@"Public key of the user {userId} has been downloaded successfully.");

        Console.WriteLine();
    }

    private async Task CngDownloadPublicKeyAsync(Actor actor, Guid userId)
    {
        var currentUserId = TokensResponse.Tokens.UserId;

        var keyExchangeRequestList = await GetKeyExchangesAsync();

        var keyExchangeRequest = actor == Actor.Receiver
            ? keyExchangeRequestList.First(request =>
                request.SenderId == userId &&
                request.ReceiverId == currentUserId &&
                request.IsConfirmed &&
                request.KeyExchangeType == KeyExchangeType.Cng)
            : keyExchangeRequestList.First(request =>
                request.ReceiverId == userId &&
                request.SenderId == currentUserId &&
                request.IsConfirmed &&
                request.KeyExchangeType == KeyExchangeType.Cng);
        var address = $"{KeyExchangeRoutes.PublicKeys}/{keyExchangeRequest.RequestId}";
        var uri = new Uri(address, UriKind.Absolute);

        var response = await HttpClient.GetAsync(uri);
        response.EnsureSuccessStatusCode();

        await using var stream = await response.Content.ReadAsStreamAsync();

        var workingDirectory = CngDirectoryHelper.CngPublicKeysDirectory;

        var publicKeyFileName = FileNameHelper.GenerateCngPublicKeyFileName(
            currentUserId,
            keyExchangeRequest.RequestId);

        var filePath = Path.Combine(workingDirectory, publicKeyFileName);

        workingDirectory.CreateDirectoryIfNotExist();

        var fileInfo = new FileInfo(filePath);

        await using var fileStream = fileInfo.OpenWrite();

        await stream.CopyToAsync(fileStream);
    }
}
