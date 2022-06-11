using MangoAPI.DiffieHellmanLibrary.Abstractions;

namespace MangoAPI.DiffieHellmanLibrary.CngHandlers;

public class CngValidateCommonSecretHandler : IValidateCommonSecretHandler
{
    public Task ValidateCommonSecretAsync(Guid senderId, Guid receiverId)
    {
        throw new NotImplementedException();
    }
}