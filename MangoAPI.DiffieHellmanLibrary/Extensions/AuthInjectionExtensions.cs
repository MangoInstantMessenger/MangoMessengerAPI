﻿using MangoAPI.DiffieHellmanLibrary.AuthHandlers;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.DiffieHellmanLibrary.Extensions;

public static class AuthInjectionExtensions
{
    public static IServiceCollection AddAuthServicesAndHandlers(this IServiceCollection collection)
    {
        collection.AddSingleton<LoginHandler>();
        collection.AddSingleton<RefreshTokenHandler>();

        return collection;
    }
}