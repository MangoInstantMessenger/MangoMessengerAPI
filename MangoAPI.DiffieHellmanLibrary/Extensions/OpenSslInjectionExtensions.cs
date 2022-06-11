using MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.DiffieHellmanLibrary.Extensions;

public static class OpenSslInjectionExtensions
{
    public static IServiceCollection AddOpenSslServicesAndHandlers(this IServiceCollection collection)
    {
        collection.AddSingleton<UploadDhParametersHandler>();
        collection.AddSingleton<DownloadDhParametersHandler>();
        collection.AddSingleton<GeneratePrivateKeyHandler>();
        collection.AddSingleton<GeneratePublicKeyHandler>();
        collection.AddSingleton<CreateKeyExchangeHandler>();
        collection.AddSingleton<PrintKeyExchangesHandler>();
        collection.AddSingleton<ConfirmKeyExchangeHandler>();
        collection.AddSingleton<CreateCommonSecretHandler>();
        collection.AddSingleton<DownloadPublicKeyHandler>();
        collection.AddSingleton<DeclineKeyExchangeHandler>();
        collection.AddSingleton<PrintKeyExchangeByIdHandler>();
        collection.AddSingleton<OpensslValidateCommonSecretHandler>();

        return collection;
    }
}