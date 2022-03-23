using MangoAPI.DiffieHellmanLibrary.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.DiffieHellmanLibrary.Extensions;

public static class ServicesInjectionExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection collection)
    {
        collection.AddSingleton<HttpClient>();
        collection.AddSingleton<CngEcdhService>();
        collection.AddSingleton<KeyExchangeService>();
        collection.AddSingleton<CngPublicKeysService>();
        collection.AddSingleton<SessionsService>();
        collection.AddSingleton<TokensService>();

        return collection;
    }
}