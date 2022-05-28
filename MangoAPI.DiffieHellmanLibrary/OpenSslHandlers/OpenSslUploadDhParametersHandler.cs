using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

public class OpenSslUploadDhParametersHandler
{
    private readonly OpenSslKeyExchangeService _openSslKeyExchangeService;

    public OpenSslUploadDhParametersHandler(OpenSslKeyExchangeService openSslKeyExchangeService)
    {
        _openSslKeyExchangeService = openSslKeyExchangeService;
    }

    public async Task<bool> UploadDhParametersAsync()
    {
        Console.WriteLine(@"Attempting to upload DH parameters file...");

        await _openSslKeyExchangeService.OpenSslUploadDhParametersAsync();

        Console.WriteLine(@"DH parameters have been updated successfully.");

        Console.WriteLine();

        return true;
    }
}