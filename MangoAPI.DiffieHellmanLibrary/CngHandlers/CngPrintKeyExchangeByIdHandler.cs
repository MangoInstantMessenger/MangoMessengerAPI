using MangoAPI.DiffieHellmanLibrary.Abstractions;

namespace MangoAPI.DiffieHellmanLibrary.CngHandlers;

public class CngPrintKeyExchangeByIdHandler : IPrintKeyExchangeByIdHandler
{
    public Task GetKeyExchangeByIdAsync(Guid requestId)
    {
        throw new NotImplementedException();
    }
}