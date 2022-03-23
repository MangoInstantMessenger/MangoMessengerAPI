using MangoAPI.DiffieHellmanConsole.AuthHandlers;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.DiffieHellmanConsole.Extensions;

public static class AuthInjectionExtensions
{
    public static IServiceCollection AddAuthHandlers(this IServiceCollection collection)
    {
        collection.AddSingleton<LoginHandler>();
        collection.AddSingleton<RefreshTokenHandler>();

        return collection;
    }
}