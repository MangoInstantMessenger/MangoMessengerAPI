using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpenSslDownloadDhParametersHandler
{
    private readonly OpenSslKeyExchangeService _openSslKeyExchangeService;

    public OpenSslDownloadDhParametersHandler(OpenSslKeyExchangeService openSslKeyExchangeService)
    {
        _openSslKeyExchangeService = openSslKeyExchangeService;
    }

    public async Task DownloadDhParametersAsync()
    {
        Console.WriteLine(@"Downloading DH parameters file ...");

        await _openSslKeyExchangeService.OpenSslDownloadDhParametersAsync();

        Console.WriteLine(@"DH parameters file has been downloaded successfully.");
        Console.WriteLine();
    }
}