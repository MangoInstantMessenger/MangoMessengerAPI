using MangoAPI.DiffieHellmanLibrary.AuthHandlers;
using MangoAPI.DiffieHellmanLibrary.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.DiffieHellmanLibrary.Extensions;

public static class AuthInjectionExtensions
{
    public static IServiceCollection AddAuthServicesAndHandlers(this IServiceCollection collection)
    {
        collection.AddSingleton<SessionsService>();

        collection.AddSingleton<LoginHandler>();
        collection.AddSingleton<RefreshTokenHandler>();

        return collection;
    }
}