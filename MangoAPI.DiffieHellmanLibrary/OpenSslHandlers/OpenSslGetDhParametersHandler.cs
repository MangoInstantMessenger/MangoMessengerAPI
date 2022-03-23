using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpenSslGetDhParametersHandler
{
    private readonly OpenSslKeyExchangeService _openSslKeyExchangeService;

    public OpenSslGetDhParametersHandler(OpenSslKeyExchangeService openSslKeyExchangeService)
    {
        _openSslKeyExchangeService = openSslKeyExchangeService;
    }

    public async Task GetDhParametersAsync()
    {
        Console.WriteLine("Downloading DH parameters file ...");

        await _openSslKeyExchangeService.OpenSslDownloadDhParametersAsync();

        Console.WriteLine("DH parameters file has been downloaded successfully.");
    }
}