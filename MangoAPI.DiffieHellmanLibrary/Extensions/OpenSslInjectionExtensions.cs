using MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.DiffieHellmanLibrary.Extensions;

public static class OpenSslInjectionExtensions
{
    public static IServiceCollection AddOpenSslServicesAndHandlers(this IServiceCollection collection)
    {
        _ = collection.AddSingleton<OpensslUploadDhParametersHandler>();
        _ = collection.AddSingleton<OpensslDownloadDhParametersHandler>();
        _ = collection.AddSingleton<OpensslGeneratePrivateKeyHandler>();
        _ = collection.AddSingleton<OpensslGeneratePublicKeyHandler>();
        _ = collection.AddSingleton<OpensslCreateKeyExchangeHandler>();
        _ = collection.AddSingleton<OpensslPrintKeyExchangesHandler>();
        _ = collection.AddSingleton<OpensslConfirmKeyExchangeHandler>();
        _ = collection.AddSingleton<OpensslCreateCommonSecretHandler>();
        _ = collection.AddSingleton<OpensslDownloadPublicKeyHandler>();
        _ = collection.AddSingleton<OpensslDeclineKeyExchangeHandler>();
        _ = collection.AddSingleton<OpensslPrintKeyExchangeByIdHandler>();
        _ = collection.AddSingleton<OpensslValidateCommonSecretHandler>();

        return collection;
    }
}