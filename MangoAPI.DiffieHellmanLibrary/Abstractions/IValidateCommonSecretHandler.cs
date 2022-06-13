namespace MangoAPI.DiffieHellmanLibrary.Abstractions;

public interface IValidateCommonSecretHandler
{
    Task ValidateCommonSecretAsync(Guid senderId, Guid receiverId);
}