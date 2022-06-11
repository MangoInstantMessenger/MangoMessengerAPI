using MangoAPI.DiffieHellmanLibrary.Abstractions;
using MangoAPI.DiffieHellmanLibrary.Constants;
using MangoAPI.DiffieHellmanLibrary.Extensions;
using MangoAPI.DiffieHellmanLibrary.Helpers;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpenSslDownloadDhParametersHandler : OpenSslBaseHandler, IDownloadDhParametersHandler
{
    public OpenSslDownloadDhParametersHandler(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task DownloadDhParametersAsync()
    {
        Console.WriteLine(@"Downloading DH parameters file ...");

        await OpenSslDownloadDhParametersAsync();

        Console.WriteLine(@"DH parameters file has been downloaded successfully.");
        Console.WriteLine();
    }

    private async Task OpenSslDownloadDhParametersAsync()
    {
        var uri = new Uri(uriString: OpenSslRoutes.OpenSslParameters, UriKind.Absolute);

        var workingDirectory = OpenSslDirectoryHelper.OpenSslDhParametersDirectory;

        var response = await HttpClient.GetAsync(uri);

        response.EnsureSuccessStatusCode();

        await using var stream = await response.Content.ReadAsStreamAsync();

        var filePath = Path.Combine(workingDirectory, FileNameHelper.DownloadedParametersFileName);

        workingDirectory.CreateDirectoryIfNotExist();

        var fileInfo = new FileInfo(filePath);

        await using var fileStream = fileInfo.OpenWrite();

        await stream.CopyToAsync(fileStream);
    }
}