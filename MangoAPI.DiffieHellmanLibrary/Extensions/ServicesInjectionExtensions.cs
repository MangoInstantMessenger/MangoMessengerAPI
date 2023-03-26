using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.DiffieHellmanLibrary.Extensions;

public static class ServicesInjectionExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection collection)
    {
        collection.AddSingleton(_ =>
        {
            var client = new HttpClient();
            return client;
        });

        return collection;
    }
}