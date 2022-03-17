using System.Net.Http;
using MangoAPI.DiffieHellmanConsole.CngHandlers;
using MangoAPI.DiffieHellmanConsole.Handlers;
using MangoAPI.DiffieHellmanConsole.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.DiffieHellmanConsole.Extensions;

public static class InjectionExtensions
{
    public static IServiceCollection AddCngServicesAndHandlers(this IServiceCollection collection)
    {
        collection.AddSingleton<HttpClient>();
        collection.AddSingleton<EcdhService>();
        collection.AddSingleton<KeyExchangeService>();
        collection.AddSingleton<PublicKeysService>();
        collection.AddSingleton<SessionsService>();
        collection.AddSingleton<TokensService>();

        collection.AddSingleton<LoginHandler>();
        collection.AddSingleton<PrintKeyExchangeListHandler>();
        collection.AddSingleton<PrintPublicKeysHandler>();
        collection.AddSingleton<RefreshTokenHandler>();

        collection.AddSingleton<CngConfirmKeyExchangeRequestHandler>();
        collection.AddSingleton<CngCreateCommonSecretHandler>();
        collection.AddSingleton<CngRequestKeyExchangeHandler>();

        return collection;
    }
}