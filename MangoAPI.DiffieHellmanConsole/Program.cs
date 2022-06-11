using System;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.DiffieHellmanLibrary.AuthHandlers;
using MangoAPI.DiffieHellmanLibrary.CngHandlers;
using MangoAPI.DiffieHellmanLibrary.Constants;
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
            Console.WriteLine(@"Unrecognized command.");
            return;
        }

        var method = args[0];

        switch (method)
        {
            case Commands.Login:
            {
                var handler = DependencyResolver.ResolveService<LoginHandler>();
                await handler.LoginAsync(args);
                break;
            }
            case Commands.RefreshToken:
            {
                var handler = DependencyResolver.ResolveService<RefreshTokenHandler>();
                await handler.RefreshTokensAsync();
                break;
            }
            case Commands.CngCreateKeyExchange:
            {
                var handler = DependencyResolver.ResolveService<CngCreateKeyExchangeHandler>();
                await handler.CngRequestKeyExchange(args);
                break;
            }
            case Commands.CngPrintKeyExchanges:
            {
                var handler = DependencyResolver.ResolveService<CngPrintKeyExchangeListHandler>();
                await handler.CngPrintKeyExchangesListAsync();
                break;
            }
            case Commands.CngConfirmKeyExchange:
            {
                var handler = DependencyResolver.ResolveService<CngConfirmKeyExchangeRequestHandler>();
                await handler.CngConfirmKeyExchangeRequest(args);
                break;
            }
            case Commands.CngPrintPublicKeys:
            {
                var handler = DependencyResolver.ResolveService<CngPrintPublicKeysHandler>();
                await handler.CngPrintPublicKeysAsync();
                break;
            }
            case Commands.CngCreateCommonSecret:
            {
                var handler = DependencyResolver.ResolveService<CngCreateCommonSecretHandler>();
                await handler.CngCreateCommonSecret(args);
                break;
            }
            case Commands.OpenSslGenerateDhParameters:
            {
                var handler = DependencyResolver.ResolveService<OpenSslGenerateDhParametersHandler>();
                await handler.CreateDhParametersAsync();
                break;
            }
            case Commands.OpenSslUploadDhParameters:
            {
                var handler = DependencyResolver.ResolveService<OpenSslUploadDhParametersHandler>();
                await handler.UploadDhParametersAsync();
                break;
            }
            case Commands.OpenSslDownloadDhParameters:
            {
                var handler = DependencyResolver.ResolveService<OpenSslDownloadDhParametersHandler>();
                await handler.DownloadDhParametersAsync();
                break;
            }
            case Commands.OpenSslGeneratePrivateKey:
            {
                var handler = DependencyResolver.ResolveService<OpenSslGeneratePrivateKeyHandler>();

                var receiverIdString = args[1];

                var receiverId = GetGuidValue(receiverIdString);

                await handler.GeneratePrivateKeyAsync(receiverId);

                break;
            }
            case Commands.OpenSslGeneratePublicKey:
            {
                var handler = DependencyResolver.ResolveService<OpenSslGeneratePublicKeyHandler>();

                var receiverIdString = args[1];

                var receiverId = GetGuidValue(receiverIdString);

                await handler.GeneratePublicKeyAsync(receiverId);

                break;
            }
            case Commands.OpenSslCreateKeyExchange:
            {
                var handler = DependencyResolver.ResolveService<OpenSslCreateKeyExchangeHandler>();

                var receiverIdString = args[1];

                var receiverId = GetGuidValue(receiverIdString);

                await handler.CreateKeyExchangeAsync(receiverId);

                break;
            }
            case Commands.OpenSslPrintKeyExchanges:
            {
                var handler = DependencyResolver.ResolveService<OpenSslPrintKeyExchangesHandler>();
                await handler.PrintKeyExchangesAsync();
                break;
            }
            case Commands.OpenSslConfirmKeyExchange:
            {
                var handler = DependencyResolver.ResolveService<OpenSslConfirmKeyExchangeHandler>();

                var userIdString = args[1];

                var userId = GetGuidValue(userIdString);

                await handler.ConfirmKeyExchangeAsync(userId);
                break;
            }
            case Commands.OpenSslCreateCommonSecret:
            {
                var handler = DependencyResolver.ResolveService<OpenSslCreateCommonSecretHandler>();

                var actorString = args[1];
                var requestIdString = args[2];

                var partnerId = GetGuidValue(requestIdString);

                var actor = actorString == "--sender"
                    ? Actor.Sender
                    : Actor.Receiver;

                await handler.CreateCommonSecretAsync(actor, partnerId);
                break;
            }
            case Commands.OpenSslDownloadPublicKey:
            {
                var handler = DependencyResolver.ResolveService<OpenSslDownloadPublicKeyHandler>();

                var actorString = args[1];
                var userIdString = args[2];

                var userId = GetGuidValue(userIdString);

                var actor = actorString == "--sender"
                    ? Actor.Sender
                    : Actor.Receiver;

                await handler.DownloadPublicKeyAsync(actor, userId);
                break;
            }
            case Commands.OpenSslDeclineKeyExchange:
            {
                var handler = DependencyResolver.ResolveService<OpenSslDeclineKeyExchangeHandler>();

                var requestIdString = args[1];

                var requestId = GetGuidValue(requestIdString);

                await handler.DeclineKeyExchangeAsync(requestId);
                break;
            }
            case Commands.OpenSslPrintKeyExchangeById:
            {
                var handler = DependencyResolver.ResolveService<OpenSslPrintKeyExchangeByIdHandler>();

                var requestIdString = args[1];

                var requestId = GetGuidValue(requestIdString);

                await handler.GetKeyExchangeByIdAsync(requestId);
                break;
            }
            case Commands.OpensslValidateCommonSecret:
            {
                var handler = DependencyResolver.ResolveService<OpensslValidateCommonSecretHandler>();

                var senderIdString = args[1];
                var receiverIdString = args[2];

                var senderId = GetGuidValue(senderIdString);
                var receiverId = GetGuidValue(receiverIdString);

                await handler.ValidateCommonSecretAsync(senderId, receiverId);
                break;
            }
            default:
            {
                Console.WriteLine(@"Unrecognized command.");
                break;
            }
        }
    }

    private static Guid GetGuidValue(string receiverIdString)
    {
        var isParsed = Guid.TryParse(receiverIdString, out var receiverId);

        if (!isParsed)
        {
            throw new InvalidCastException("ReceiverId is not a valid Guid.");
        }

        return receiverId;
    }
}