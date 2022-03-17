using System;
using System.Threading.Tasks;
using MangoAPI.DiffieHellmanConsole.CngHandlers;
using MangoAPI.DiffieHellmanConsole.Extensions;
using MangoAPI.DiffieHellmanConsole.Handlers;
using Microsoft.Extensions.DependencyInjection;

namespace MangoAPI.DiffieHellmanConsole;

public static class Program
{
    public static async Task Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Unrecognized command.");
            return;
        }

        var serviceProvider = new ServiceCollection()
            .AddCngServicesAndHandlers()
            .BuildServiceProvider();

        var method = args[0];

        switch (method)
        {
            case "login":
            {
                var handler = serviceProvider.GetService<LoginHandler>() ??
                              throw new ArgumentException(
                                  $"Handler is null. Register it in dependency injection. {nameof(LoginHandler)}");

                await handler.LoginAsync(args);
                break;
            }
            case "refresh-token":
            {
                var refreshHandler = serviceProvider.GetService<RefreshTokenHandler>() ??
                                     throw new ArgumentException(
                                         $"Handler is null. Register it in dependency injection. {nameof(RefreshTokenHandler)}");

                await refreshHandler.RefreshTokensAsync();
                break;
            }
            case "key-exchange":
            {
                var handler = serviceProvider.GetService<CngRequestKeyExchangeHandler>() ??
                              throw new ArgumentException(
                                  $"Handler is null. Register it in dependency injection. {nameof(CngRequestKeyExchangeHandler)}");

                await handler.RequestKeyExchange(args);
                break;
            }
            case "key-exchange-requests":
            {
                var handler = serviceProvider.GetService<PrintKeyExchangeListHandler>() ??
                              throw new ArgumentException(
                                  $"Handler is null. Register it in dependency injection. {nameof(PrintKeyExchangeListHandler)}");

                await handler.PrintKeyExchangesListAsync();
                break;
            }
            case "confirm-key-exchange":
            {
                var handler = serviceProvider.GetService<CngConfirmKeyExchangeRequestHandler>() ??
                              throw new ArgumentException(
                                  $"Handler is null. Register it in dependency injection. {nameof(CngConfirmKeyExchangeRequestHandler)}");

                await handler.ConfirmKeyExchangeRequest(args);
                break;
            }
            case "print-public-keys":
            {
                var handler = serviceProvider.GetService<PrintPublicKeysHandler>() ??
                              throw new ArgumentException(
                                  $"Handler is null. Register it in dependency injection. {nameof(PrintPublicKeysHandler)}");

                await handler.PrintPublicKeysAsync();
                break;
            }
            case "create-common-secret":
            {
                var handler = serviceProvider.GetService<CngCreateCommonSecretHandler>() ??
                              throw new ArgumentException(
                                  $"Handler is null. Register it in dependency injection. {nameof(CngCreateCommonSecretHandler)}");
                
                await handler.CreateCommonSecret(args);
                break;
            }
            default:
            {
                Console.WriteLine("Unrecognized command.");
                break;
            }
        }
    }
}