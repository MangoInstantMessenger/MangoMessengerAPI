using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.DiffieHellmanLibrary.Extensions;

public static class ServicesInjectionExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection collection)
    {
        collection.AddSingleton(_ =>
        {
            var clientHandler = new HttpClientHandler();

            clientHandler.ServerCertificateCustomValidationCallback
                = (_, _, _, _) => true;

            var client = new HttpClient(clientHandler);

            return client;
        });

        return collection;
    }
}