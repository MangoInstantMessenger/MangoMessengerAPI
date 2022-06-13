using MangoAPI.BusinessLogic.Models;

namespace MangoAPI.DiffieHellmanLibrary.Abstractions;

public interface IDownloadPublicKeyHandler
{
    Task DownloadPublicKeyAsync(Actor actor, Guid userId);
}