using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanLibrary.CngHandlers;

public class CngPrintPublicKeysHandler
{
    private readonly CngPublicKeysService _cngPublicKeysService;

    public CngPrintPublicKeysHandler(CngPublicKeysService cngPublicKeysService)
    {
        _cngPublicKeysService = cngPublicKeysService;
    }

    public async Task CngPrintPublicKeysAsync()
    {
        var response = await _cngPublicKeysService.CngGetPublicKeys();
        response.PublicKeys.ForEach(Console.WriteLine);
    }
}