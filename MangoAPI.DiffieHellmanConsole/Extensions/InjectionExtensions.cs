using System.Net.Http;
using MangoAPI.DiffieHellmanConsole.CngHandlers;
using MangoAPI.DiffieHellmanConsole.Handlers;
using MangoAPI.DiffieHellmanConsole.OpenSslHandlers;
using MangoAPI.DiffieHellmanConsole.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.DiffieHellmanConsole.Extensions;

public static class InjectionExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection collection)
    {
        collection.AddSingleton<HttpClient>();
        collection.AddSingleton<EcdhService>();
        collection.AddSingleton<KeyExchangeService>();
        collection.AddSingleton<PublicKeysService>();
        collection.AddSingleton<SessionsService>();
        collection.AddSingleton<TokensService>();

        collection.AddSingleton<LoginHandler>();
        collection.AddSingleton<RefreshTokenHandler>();

        return collection;
    }

    public static IServiceCollection AddAuthHandlers(this IServiceCollection collection)
    {
        collection.AddSingleton<LoginHandler>();
        collection.AddSingleton<RefreshTokenHandler>();

        return collection;
    }

    public static IServiceCollection AddCngHandlers(this IServiceCollection collection)
    {
        collection.AddSingleton<CngPrintKeyExchangeListHandler>();
        collection.AddSingleton<CngPrintPublicKeysHandler>();
        collection.AddSingleton<CngConfirmKeyExchangeRequestHandler>();
        collection.AddSingleton<CngCreateCommonSecretHandler>();
        collection.AddSingleton<CngRequestKeyExchangeHandler>();

        return collection;
    }

    public static IServiceCollection AddOpenSslHandlers(this IServiceCollection collection)
    {
        collection.AddSingleton<OpenSslCreateDhParametersHandler>();
        collection.AddSingleton<OpenSslUploadDhParametersHandler>();
        collection.AddSingleton<OpenSslGetDhParametersHandler>();

        return collection;
    }
}