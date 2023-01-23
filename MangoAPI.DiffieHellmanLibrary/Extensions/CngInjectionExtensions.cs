using MangoAPI.DiffieHellmanLibrary.CngHandlers;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.DiffieHellmanLibrary.Extensions;

public static class CngInjectionExtensions
{
    public static IServiceCollection AddCngServicesAndHandlers(this IServiceCollection collection)
    {
        _ = collection.AddSingleton<CngGeneratePrivateKeyHandler>();
        _ = collection.AddSingleton<CngGeneratePublicKeyHandler>();
        _ = collection.AddSingleton<CngPrintKeyExchangesHandler>();
        _ = collection.AddSingleton<CngConfirmKeyExchangeHandler>();
        _ = collection.AddSingleton<CngCreateCommonSecretHandler>();
        _ = collection.AddSingleton<CngCreateKeyExchangeHandler>();
        _ = collection.AddSingleton<CngDownloadPublicKeyHandler>();
        _ = collection.AddSingleton<CngValidateCommonSecretHandler>();

        return collection;
    }
}