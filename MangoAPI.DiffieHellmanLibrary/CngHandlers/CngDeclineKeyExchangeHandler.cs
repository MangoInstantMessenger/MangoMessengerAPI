using MangoAPI.DiffieHellmanLibrary.Abstractions;

namespace MangoAPI.DiffieHellmanLibrary.CngHandlers;

public class CngDeclineKeyExchangeHandler : IDeclineKeyExchangeHandler
{
    public Task DeclineKeyExchangeAsync(Guid requestId)
    {
        throw new NotImplementedException();
    }
}