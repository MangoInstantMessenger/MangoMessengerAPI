using MangoAPI.DiffieHellmanLibrary.CngHandlers;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.DiffieHellmanLibrary.Extensions;

public static class CngInjectionExtensions
{
    public static IServiceCollection AddCngServicesAndHandlers(this IServiceCollection collection)
    {
        collection.AddSingleton<CngGeneratePrivateKeyHandler>();
        collection.AddSingleton<CngGeneratePublicKeyHandler>();
        collection.AddSingleton<CngPrintKeyExchangesHandler>();
        collection.AddSingleton<CngConfirmKeyExchangeHandler>();
        collection.AddSingleton<CngCreateCommonSecretHandler>();
        collection.AddSingleton<CngCreateKeyExchangeHandler>();
        collection.AddSingleton<CngDownloadPublicKeyHandler>();

        return collection;
    }
}