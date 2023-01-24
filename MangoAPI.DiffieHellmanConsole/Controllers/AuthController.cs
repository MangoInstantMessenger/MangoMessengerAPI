using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MangoAPI.DiffieHellmanLibrary.AuthHandlers;
using MangoAPI.DiffieHellmanLibrary.Constants;
using MangoAPI.DiffieHellmanLibrary.Helpers;

namespace MangoAPI.DiffieHellmanConsole.Controllers;

public static class AuthController
{
    public static async Task FetchAuthHandlerAsync(IReadOnlyList<string> args, string method)
    {
        switch (method)
        {
            case Commands.Login:
                {
                    var login = args[1];
                    var password = args[2];
                    var handler = DependencyResolver.ResolveService<LoginHandler>();
                    await handler.LoginAsync(login, password);
                    break;
                }

            case Commands.RefreshToken:
                {
                    var handler = DependencyResolver.ResolveService<RefreshTokenHandler>();
                    await handler.RefreshTokensAsync();
                    break;
                }

            default:
                {
                    Console.WriteLine(@"Unrecognized command.");
                    break;
                }
        }
    }
}
