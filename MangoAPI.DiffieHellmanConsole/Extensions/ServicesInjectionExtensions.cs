using System.Net.Http;
using MangoAPI.DiffieHellmanConsole.AuthHandlers;
using MangoAPI.DiffieHellmanConsole.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.DiffieHellmanConsole.Extensions;

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

        collection.AddSingleton<LoginHandler>();
        collection.AddSingleton<RefreshTokenHandler>();

        return collection;
    }
}