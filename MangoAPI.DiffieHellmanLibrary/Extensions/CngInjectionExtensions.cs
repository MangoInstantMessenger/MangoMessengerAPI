using MangoAPI.DiffieHellmanLibrary.CngHandlers;
using MangoAPI.DiffieHellmanLibrary.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.DiffieHellmanLibrary.Extensions;

public static class CngInjectionExtensions
{
    public static IServiceCollection AddCngServicesAndHandlers(this IServiceCollection collection)
    {
        collection.AddSingleton<CngEcdhService>();
        collection.AddSingleton<CngKeyExchangeService>();
        collection.AddSingleton<CngPublicKeysService>();
        
        collection.AddSingleton<CngPrintKeyExchangeListHandler>();
        collection.AddSingleton<CngPrintPublicKeysHandler>();
        collection.AddSingleton<CngConfirmKeyExchangeRequestHandler>();
        collection.AddSingleton<CngCreateCommonSecretHandler>();
        collection.AddSingleton<CngRequestKeyExchangeHandler>();

        return collection;
    }
}