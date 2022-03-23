using System;
using System.Threading.Tasks;
using MangoAPI.DiffieHellmanLibrary.AuthHandlers;
using MangoAPI.DiffieHellmanLibrary.CngHandlers;
using MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;
using MangoAPI.DiffieHellmanLibrary.Services;

namespace MangoAPI.DiffieHellmanConsole;

public static class Program
{
    private static readonly DependencyResolver DependencyResolver = new();

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
                var handler = DependencyResolver.ResolveService<LoginHandler>();
                await handler.LoginAsync(args);
                break;
            }
            case "refresh-token":
            {
                var handler = DependencyResolver.ResolveService<RefreshTokenHandler>();
                await handler.RefreshTokensAsync();
                break;
            }
            case "cng-create-key-exchange":
            {
                var handler = DependencyResolver.ResolveService<CngCreateKeyExchangeHandler>();
                await handler.CngRequestKeyExchange(args);
                break;
            }
            case "cng-key-exchange-requests":
            {
                var handler = DependencyResolver.ResolveService<CngPrintKeyExchangeListHandler>();
                await handler.CngPrintKeyExchangesListAsync();
                break;
            }
            case "cng-confirm-key-exchange":
            {
                var handler = DependencyResolver.ResolveService<CngConfirmKeyExchangeRequestHandler>();
                await handler.CngConfirmKeyExchangeRequest(args);
                break;
            }
            case "cng-print-public-keys":
            {
                var handler = DependencyResolver.ResolveService<CngPrintPublicKeysHandler>();
                await handler.CngPrintPublicKeysAsync();
                break;
            }
            case "cng-create-common-secret":
            {
                var handler = DependencyResolver.ResolveService<CngCreateCommonSecretHandler>();
                await handler.CngCreateCommonSecret(args);
                break;
            }
            case "openssl-generate-dh-parameters":
            {
                var handler = DependencyResolver.ResolveService<OpenSslCreateDhParametersHandler>();
                await handler.CreateDhParametersAsync();
                break;
            }
            case "openssl-upload-dh-parameters":
            {
                var handler = DependencyResolver.ResolveService<OpenSslUploadDhParametersHandler>();
                await handler.UploadDhParametersAsync();
                break;
            }
            case "openssl-get-dh-parameters":
            {
                var handler = DependencyResolver.ResolveService<OpenSslGetDhParametersHandler>();
                await handler.GetDhParametersAsync();
                break;
            }
            case "openssl-generate-private-key":
            {
                var handler = DependencyResolver.ResolveService<OpenSslGeneratePrivateKeyHandler>();

                var receiverIdString = args[1];

                var isParsed = Guid.TryParse(receiverIdString, out var receiverId);

                if (!isParsed)
                {
                    Console.WriteLine("Invalid or empty receiver ID.");
                    return;
                }

                await handler.GeneratePrivateKeyAsync(receiverId);

                break;
            }
            case "openssl-generate-public-key":
            {
                var handler = DependencyResolver.ResolveService<OpenSslGeneratePublicKeyHandler>();

                var receiverIdString = args[1];

                var isParsed = Guid.TryParse(receiverIdString, out var receiverId);

                if (!isParsed)
                {
                    Console.WriteLine("Invalid or empty receiver ID.");
                    return;
                }

                await handler.GeneratePublicKeyAsync(receiverId);

                break;
            }
            case "openssl-create-key-exchange":
            {
                var handler = DependencyResolver.ResolveService<OpenSslCreateKeyExchangeHandler>();

                var receiverIdString = args[1];

                var isParsed = Guid.TryParse(receiverIdString, out var receiverId);

                if (!isParsed)
                {
                    Console.WriteLine("Invalid or empty receiver ID.");
                    return;
                }

                await handler.CreateKeyExchangeAsync(receiverId);

                break;
            }
            case "openssl-print-key-exchanges":
            {
                var handler = DependencyResolver.ResolveService<OpenSslPrintKeyExchangesHandler>();
                await handler.PrintKeyExchangesAsync();
                break;
            }
            case "openssl-confirm-key-exchange":
            {
                var handler = DependencyResolver.ResolveService<OpenSslConfirmKeyExchangeHandler>();

                var requestIdString = args[1];

                var isParsed = Guid.TryParse(requestIdString, out var requestId);

                if (!isParsed)
                {
                    Console.WriteLine("Invalid or empty request ID.");
                    return;
                }

                await handler.ConfirmKeyExchangeAsync(requestId);
                break;
            }
            case "openssl-create-common-secret":
            {
                var handler = DependencyResolver.ResolveService<OpenSslCreateCommonSecretHandler>();

                var requestIdString = args[1];

                var isParsed = Guid.TryParse(requestIdString, out var requestId);

                if (!isParsed)
                {
                    Console.WriteLine("Invalid or empty request ID.");
                    return;
                }

                await handler.CreateCommonSecretAsync(requestId);
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