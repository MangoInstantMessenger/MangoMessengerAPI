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
                var handler = serviceProvider.GetService<LoginHandler>();
                await handler.LoginAsync(args);
                break;
            }
            case "refresh-token":
            {
                var refreshHandler = serviceProvider.GetService<RefreshTokenHandler>();
                await refreshHandler.RefreshTokensAsync();
                break;
            }
            case "key-exchange":
            {
                var handler = serviceProvider.GetService<CngRequestKeyExchangeHandler>();
                await handler.RequestKeyExchange(args);
                break;
            }
            case "key-exchange-requests":
            {
                var handler = serviceProvider.GetService<PrintKeyExchangeListHandler>();

                await handler.PrintKeyExchangesListAsync();
                break;
            }
            case "confirm-key-exchange":
            {
                var handler = serviceProvider.GetService<CngConfirmKeyExchangeRequestHandler>();
                await handler.ConfirmKeyExchangeRequest(args);
                break;
            }
            case "print-public-keys":
            {
                var handler = serviceProvider.GetService<PrintPublicKeysHandler>();
                await handler.PrintPublicKeysAsync();
                break;
            }
            case "create-common-secret":
            {
                var handler = serviceProvider.GetService<CngCreateCommonSecretHandler>();
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