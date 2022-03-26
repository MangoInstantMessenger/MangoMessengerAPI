using MangoAPI.DiffieHellmanLibrary.Consts;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.DiffieHellmanLibrary.Extensions;

public static class ServicesInjectionExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection collection)
    {
        collection.AddHttpClient(Routes.Domain).ConfigurePrimaryHttpMessageHandler(_ => new HttpClientHandler
        {
            ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
        });

        return collection;
    }
}