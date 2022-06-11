using MangoAPI.DiffieHellmanLibrary.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.DiffieHellmanLibrary.Services;

public static class DependencyResolver
{
    private static readonly ServiceProvider ServiceProvider;

    static DependencyResolver()
    {
        ServiceProvider = new ServiceCollection()
            .AddServices()
            .AddAuthServicesAndHandlers()
            .AddCngServicesAndHandlers()
            .AddOpenSslServicesAndHandlers()
            .BuildServiceProvider();
    }

    public static T ResolveService<T>()
    {
        var service = ServiceProvider.GetService<T>() ??
                      throw new ArgumentException(
                          $"Handler is null. Register it in dependency injection. {nameof(T)}");

        return service;
    }
}