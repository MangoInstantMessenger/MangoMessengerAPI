using MangoAPI.BusinessLogic.Models;
using MangoAPI.DiffieHellmanLibrary.Abstractions;

namespace MangoAPI.DiffieHellmanLibrary.CngHandlers;

public class CngDownloadPublicKeyHandler : IDownloadPublicKeyHandler
{
    public Task DownloadPublicKeyAsync(Actor actor, Guid userId)
    {
        throw new NotImplementedException();
    }
}