using MangoAPI.DiffieHellmanLibrary.Abstractions;

namespace MangoAPI.DiffieHellmanLibrary.CngHandlers;

public class CngGeneratePrivateKeyHandler : IGeneratePrivateKeyHandler
{
    public Task GeneratePrivateKeyAsync(Guid receiverId)
    {
        throw new NotImplementedException();
    }
}