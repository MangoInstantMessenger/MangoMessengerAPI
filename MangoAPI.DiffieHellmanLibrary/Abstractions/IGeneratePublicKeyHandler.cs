namespace MangoAPI.DiffieHellmanLibrary.Abstractions;

public interface IGeneratePublicKeyHandler
{
    Task GeneratePublicKeyAsync(Guid receiverId);
}