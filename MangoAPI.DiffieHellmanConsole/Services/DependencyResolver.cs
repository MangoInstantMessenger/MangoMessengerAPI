using System;
using MangoAPI.DiffieHellmanConsole.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.DiffieHellmanConsole.Services;

public class DependencyResolver
{
    private static ServiceProvider _serviceProvider;

    public DependencyResolver()
    {
        _serviceProvider = new ServiceCollection()
            .AddAuthHandlers()
            .AddServices()
            .AddCngHandlers()
            .AddOpenSslHandlers()
            .BuildServiceProvider();
    }

    public T ResolveService<T>()
    {
        var service = _serviceProvider.GetService<T>() ??
                      throw new ArgumentException(
                          $"Handler is null. Register it in dependency injection. {nameof(T)}");

        return service;
    }
}