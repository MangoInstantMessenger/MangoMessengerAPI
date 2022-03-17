using System;
using System.Threading.Tasks;
using MangoAPI.DiffieHellmanConsole.Services;

namespace MangoAPI.DiffieHellmanConsole.Handlers;

public class PrintPublicKeysHandler
{
    private readonly PublicKeysService _publicKeysService;

    public PrintPublicKeysHandler(PublicKeysService publicKeysService)
    {
        _publicKeysService = publicKeysService;
    }

    public async Task PrintPublicKeysAsync()
    {
        var response = await _publicKeysService.GetPublicKeys();
        response.PublicKeys.ForEach(Console.WriteLine);
    }
}