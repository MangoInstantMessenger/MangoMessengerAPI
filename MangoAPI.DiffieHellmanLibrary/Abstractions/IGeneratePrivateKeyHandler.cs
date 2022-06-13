namespace MangoAPI.DiffieHellmanLibrary.Abstractions;

public interface IGeneratePrivateKeyHandler
{
    Task GeneratePrivateKeyAsync(Guid receiverId);
}