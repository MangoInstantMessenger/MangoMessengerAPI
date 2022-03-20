using System;
using System.Threading.Tasks;
using MangoAPI.DiffieHellmanConsole.Services;

namespace MangoAPI.DiffieHellmanConsole.OpenSslHandlers;

public class OpenSslUploadDhParametersHandler
{
    private readonly KeyExchangeService _keyExchangeService;

    public OpenSslUploadDhParametersHandler(KeyExchangeService keyExchangeService)
    {
        _keyExchangeService = keyExchangeService;
    }

    public async Task<bool> UploadDhParametersAsync()
    {
        Console.WriteLine("Attempting to upload DH parameters file...");
        await _keyExchangeService.OpenSslUploadDhParametersAsync();
        Console.WriteLine("DH parameters have been updated successfully.");
        return true;
    }
}