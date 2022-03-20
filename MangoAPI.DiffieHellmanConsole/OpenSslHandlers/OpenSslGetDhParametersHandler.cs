using System;
using System.Threading.Tasks;
using MangoAPI.DiffieHellmanConsole.Services;

namespace MangoAPI.DiffieHellmanConsole.OpenSslHandlers;

public class OpenSslGetDhParametersHandler
{
    private readonly KeyExchangeService _keyExchangeService;

    public OpenSslGetDhParametersHandler(KeyExchangeService keyExchangeService)
    {
        _keyExchangeService = keyExchangeService;
    }

    public async Task GetDhParametersAsync()
    {
        Console.WriteLine("Downloading DH parameters file ...");

        await _keyExchangeService.OpenSslDownloadDhParametersAsync();

        Console.WriteLine("DH parameters file has been downloaded successfully.");
    }
}