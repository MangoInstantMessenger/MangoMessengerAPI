using System;
using System.Threading.Tasks;
using MangoAPI.DiffieHellmanConsole.CngHandlers;
using MangoAPI.DiffieHellmanConsole.Handlers;
using MangoAPI.DiffieHellmanConsole.Services;

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

        var method = args[0];

        switch (method)
        {
            case "login":
            {
                var sessionService = new SessionsService();
                var tokensService = new TokensService();

                var handler = new LoginHandler(sessionService, tokensService);

                await handler.LoginAsync(args);
                break;
            }
            case "refresh-token":
            {
                var sessionService = new SessionsService();
                var tokensService = new TokensService();

                var refreshHandler = new RefreshTokenHandler(sessionService, tokensService);

                await refreshHandler.RefreshTokensAsync();
                break;
            }
            case "key-exchange":
            {
                var tokensService = new TokensService();
                var tokensResponse = await tokensService.GetTokensAsync();

                if (tokensResponse == null)
                {
                    Console.WriteLine("Tokens are null.");
                    return;
                }

                var tokens = tokensResponse.Tokens;

                var keyExchangeService = new KeyExchangeService(tokens.AccessToken);
                var ecdhService = new EcdhService();

                var handler = new CngRequestKeyExchangeHandler(keyExchangeService, tokensService, ecdhService);

                await handler.RequestKeyExchange(args);
                break;
            }
            case "key-exchange-requests":
            {
                var tokensService = new TokensService();
                var tokensResponse = await tokensService.GetTokensAsync();

                if (tokensResponse == null)
                {
                    Console.WriteLine("Tokens are null.");
                    return;
                }

                var tokens = tokensResponse.Tokens;

                var keyExchangeService = new KeyExchangeService(tokens.AccessToken);

                var handler = new PrintKeyExchangeListHandler(keyExchangeService);

                await handler.PrintKeyExchangesListAsync();
                break;
            }
            case "confirm-key-exchange":
            {
                var handler = new CngConfirmKeyExchangeRequestHandler();
                await handler.ConfirmKeyExchangeRequest(args);
                break;
            }
            case "print-public-keys":
            {
                var handler = new PrintPublicKeysHandler();
                await handler.PrintPublicKeysAsync();
                break;
            }
            case "create-common-secret":
            {
                var handler = new CngCreateCommonSecretHandler();
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