using MangoAPI.DiffieHellmanLibrary.CngHandlers;
using MangoAPI.DiffieHellmanLibrary.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.DiffieHellmanLibrary.Extensions;

public static class CngInjectionExtensions
{
    public static IServiceCollection AddCngServicesAndHandlers(this IServiceCollection collection)
    {
        collection.AddSingleton<CngKeyExchangeService>();
        collection.AddSingleton<CngPublicKeysService>();
        
        collection.AddSingleton<CngPrintKeyExchangesHandler>();
        collection.AddSingleton<CngPrintPublicKeysHandler>();
        collection.AddSingleton<CngConfirmKeyExchangeHandler>();
        collection.AddSingleton<CngCreateCommonSecretHandler>();
        collection.AddSingleton<CngCreateKeyExchangeHandler>();

        return collection;
    }
}