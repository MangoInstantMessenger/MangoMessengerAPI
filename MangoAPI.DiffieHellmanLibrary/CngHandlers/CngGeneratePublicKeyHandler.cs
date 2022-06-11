using MangoAPI.DiffieHellmanLibrary.Abstractions;

namespace MangoAPI.DiffieHellmanLibrary.CngHandlers;

public class CngGeneratePublicKeyHandler : IGeneratePublicKeyHandler
{
    public Task GeneratePublicKeyAsync(Guid receiverId)
    {
        throw new NotImplementedException();
    }
}