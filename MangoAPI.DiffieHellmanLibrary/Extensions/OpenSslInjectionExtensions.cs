using MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;
using MangoAPI.DiffieHellmanLibrary.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.DiffieHellmanLibrary.Extensions;

public static class OpenSslInjectionExtensions
{
    public static IServiceCollection AddOpenSslServicesAndHandlers(this IServiceCollection collection)
    {
        collection.AddSingleton<OpenSslKeyExchangeService>();

        collection.AddSingleton<OpenSslCreateDhParametersHandler>();
        collection.AddSingleton<OpenSslUploadDhParametersHandler>();
        collection.AddSingleton<OpenSslDownloadDhParametersHandler>();
        collection.AddSingleton<OpenSslGeneratePrivateKeyHandler>();
        collection.AddSingleton<OpenSslGeneratePublicKeyHandler>();
        collection.AddSingleton<OpenSslCreateKeyExchangeHandler>();
        collection.AddSingleton<OpenSslPrintKeyExchangesHandler>();
        collection.AddSingleton<OpenSslConfirmKeyExchangeHandler>();
        collection.AddSingleton<OpenSslCreateCommonSecretHandler>();
        collection.AddSingleton<OpenSslDownloadPublicKeyHandler>();
        collection.AddSingleton<OpenSslDeclineKeyExchangeHandler>();

        return collection;
    }
}