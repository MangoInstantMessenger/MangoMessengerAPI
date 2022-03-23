using MangoAPI.DiffieHellmanLibrary.CngHandlers;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.DiffieHellmanLibrary.Extensions;

public static class CngInjectionExtensions
{
    public static IServiceCollection AddCngHandlers(this IServiceCollection collection)
    {
        collection.AddSingleton<CngPrintKeyExchangeListHandler>();
        collection.AddSingleton<CngPrintPublicKeysHandler>();
        collection.AddSingleton<CngConfirmKeyExchangeRequestHandler>();
        collection.AddSingleton<CngCreateCommonSecretHandler>();
        collection.AddSingleton<CngRequestKeyExchangeHandler>();

        return collection;
    }
}