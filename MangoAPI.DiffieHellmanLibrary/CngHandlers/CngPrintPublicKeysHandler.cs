using MangoAPI.DiffieHellmanLibrary.Abstractions;

namespace MangoAPI.DiffieHellmanLibrary.CngHandlers;

public class CngPrintPublicKeysHandler : BaseHandler
{
    public CngPrintPublicKeysHandler(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task CngPrintPublicKeysAsync()
    {
        var response = await CngGetPublicKeys();
        response.PublicKeys.ForEach(Console.WriteLine);
    }
}