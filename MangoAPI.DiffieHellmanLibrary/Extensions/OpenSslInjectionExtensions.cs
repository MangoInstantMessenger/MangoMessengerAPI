using MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.DiffieHellmanLibrary.Extensions;

public static class OpenSslInjectionExtensions
{
    public static IServiceCollection AddOpenSslServicesAndHandlers(this IServiceCollection collection)
    {
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
        collection.AddSingleton<OpenSslPrintKeyExchangeByIdHandler>();

        return collection;
    }
}