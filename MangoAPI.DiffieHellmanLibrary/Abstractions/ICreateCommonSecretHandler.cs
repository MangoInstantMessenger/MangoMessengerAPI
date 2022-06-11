using MangoAPI.BusinessLogic.Models;

namespace MangoAPI.DiffieHellmanLibrary.Abstractions;

public interface ICreateCommonSecretHandler
{
    Task CreateCommonSecretAsync(Actor actor, Guid userId);
}