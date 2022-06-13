namespace MangoAPI.DiffieHellmanLibrary.Abstractions;

public interface IDeclineKeyExchangeHandler
{
    Task DeclineKeyExchangeAsync(Guid requestId);
}