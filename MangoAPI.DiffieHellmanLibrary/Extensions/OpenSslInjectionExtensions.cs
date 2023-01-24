using MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.DiffieHellmanLibrary.Extensions;

public static class OpenSslInjectionExtensions
{
    public static IServiceCollection AddOpenSslServicesAndHandlers(this IServiceCollection collection)
    {
        collection.AddSingleton<OpensslUploadDhParametersHandler>();
        collection.AddSingleton<OpensslDownloadDhParametersHandler>();
        collection.AddSingleton<OpensslGeneratePrivateKeyHandler>();
        collection.AddSingleton<OpensslGeneratePublicKeyHandler>();
        collection.AddSingleton<OpensslCreateKeyExchangeHandler>();
        collection.AddSingleton<OpensslPrintKeyExchangesHandler>();
        collection.AddSingleton<OpensslConfirmKeyExchangeHandler>();
        collection.AddSingleton<OpensslCreateCommonSecretHandler>();
        collection.AddSingleton<OpensslDownloadPublicKeyHandler>();
        collection.AddSingleton<OpensslDeclineKeyExchangeHandler>();
        collection.AddSingleton<OpensslPrintKeyExchangeByIdHandler>();
        collection.AddSingleton<OpensslValidateCommonSecretHandler>();

        return collection;
    }
}