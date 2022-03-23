using MangoAPI.DiffieHellmanConsole.OpenSslHandlers;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.DiffieHellmanConsole.Extensions;

public static class OpenSslInjectionExtensions
{
    public static IServiceCollection AddOpenSslHandlers(this IServiceCollection collection)
    {
        collection.AddSingleton<OpenSslCreateDhParametersHandler>();
        collection.AddSingleton<OpenSslUploadDhParametersHandler>();
        collection.AddSingleton<OpenSslGetDhParametersHandler>();
        collection.AddSingleton<OpenSslGeneratePrivateKeyHandler>();
        collection.AddSingleton<OpenSslGeneratePublicKeyHandler>();
        collection.AddSingleton<OpenSslCreateKeyExchangeHandler>();
        collection.AddSingleton<OpenSslPrintKeyExchangesHandler>();
        collection.AddSingleton<OpenSslConfirmKeyExchangeHandler>();
        collection.AddSingleton<OpenSslCreateCommonSecretHandler>();

        return collection;
    }
}