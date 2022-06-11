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
            case Commands.CngCreateKeyExchange:
            {
                var receiverIdString = args[1];
                var receiverId = GetGuidValue(receiverIdString);
                var handler = DependencyResolver.ResolveService<CngCreateKeyExchangeHandler>();
                await handler.CreateKeyExchangeAsync(receiverId);
                break;
            }
            case Commands.CngPrintKeyExchanges:
            {
                var handler = DependencyResolver.ResolveService<CngPrintKeyExchangesHandler>();
                await handler.PrintKeyExchangesAsync();
                break;
            }
            case Commands.CngConfirmKeyExchange:
            {
                var requestIdString = args[1];
                var requestId = GetGuidValue(requestIdString);
                var handler = DependencyResolver.ResolveService<CngConfirmKeyExchangeHandler>();
                await handler.ConfirmKeyExchangeAsync(requestId);
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
                var actorString = args[1];
                var requestIdString = args[2];
                var partnerId = GetGuidValue(requestIdString);
                var actor = actorString == "--sender" ? Actor.Sender : Actor.Receiver;
                var handler = DependencyResolver.ResolveService<CngCreateCommonSecretHandler>();
                await handler.CreateCommonSecretAsync(actor, partnerId);
                break;
            }
            case Commands.OpenSslGenerateDhParameters:
            {
                await OpenSslGenerateDhParametersHandler.CreateDhParametersAsync();
                break;
            }
            case Commands.OpenSslUploadDhParameters:
            {
                var handler = DependencyResolver.ResolveService<UploadDhParametersHandler>();
                await handler.UploadDhParametersAsync();
                break;
            }
            case Commands.OpenSslDownloadDhParameters:
            {
                var handler = DependencyResolver.ResolveService<DownloadDhParametersHandler>();
                await handler.DownloadDhParametersAsync();
                break;
            }
            case Commands.OpenSslGeneratePrivateKey:
            {
                var receiverIdString = args[1];
                var receiverId = GetGuidValue(receiverIdString);
                var handler = DependencyResolver.ResolveService<GeneratePrivateKeyHandler>();
                await handler.GeneratePrivateKeyAsync(receiverId);
                break;
            }
            case Commands.OpenSslGeneratePublicKey:
            {
                var receiverIdString = args[1];
                var receiverId = GetGuidValue(receiverIdString);
                var handler = DependencyResolver.ResolveService<GeneratePublicKeyHandler>();
                await handler.GeneratePublicKeyAsync(receiverId);

                break;
            }
            case Commands.OpenSslCreateKeyExchange:
            {
                var receiverIdString = args[1];
                var receiverId = GetGuidValue(receiverIdString);
                var handler = DependencyResolver.ResolveService<CreateKeyExchangeHandler>();
                await handler.CreateKeyExchangeAsync(receiverId);
                break;
            }
            case Commands.OpenSslPrintKeyExchanges:
            {
                var handler = DependencyResolver.ResolveService<PrintKeyExchangesHandler>();
                await handler.PrintKeyExchangesAsync();
                break;
            }
            case Commands.OpenSslConfirmKeyExchange:
            {
                var userIdString = args[1];
                var userId = GetGuidValue(userIdString);
                var handler = DependencyResolver.ResolveService<ConfirmKeyExchangeHandler>();
                await handler.ConfirmKeyExchangeAsync(userId);
                break;
            }
            case Commands.OpenSslCreateCommonSecret:
            {
                var actorString = args[1];
                var requestIdString = args[2];
                var partnerId = GetGuidValue(requestIdString);
                var actor = actorString == "--sender" ? Actor.Sender : Actor.Receiver;
                var handler = DependencyResolver.ResolveService<CreateCommonSecretHandler>();
                await handler.CreateCommonSecretAsync(actor, partnerId);
                break;
            }
            case Commands.OpenSslDownloadPublicKey:
            {
                var actorString = args[1];
                var userIdString = args[2];
                var userId = GetGuidValue(userIdString);
                var actor = actorString == "--sender" ? Actor.Sender : Actor.Receiver;
                var handler = DependencyResolver.ResolveService<DownloadPublicKeyHandler>();
                await handler.DownloadPublicKeyAsync(actor, userId);
                break;
            }
            case Commands.OpenSslDeclineKeyExchange:
            {
                var requestIdString = args[1];
                var requestId = GetGuidValue(requestIdString);
                var handler = DependencyResolver.ResolveService<DeclineKeyExchangeHandler>();
                await handler.DeclineKeyExchangeAsync(requestId);
                break;
            }
            case Commands.OpenSslPrintKeyExchangeById:
            {
                var requestIdString = args[1];
                var requestId = GetGuidValue(requestIdString);
                var handler = DependencyResolver.ResolveService<PrintKeyExchangeByIdHandler>();
                await handler.GetKeyExchangeByIdAsync(requestId);
                break;
            }
            case Commands.OpensslValidateCommonSecret:
            {
                var senderIdString = args[1];
                var receiverIdString = args[2];
                var senderId = GetGuidValue(senderIdString);
                var receiverId = GetGuidValue(receiverIdString);
                var handler = DependencyResolver.ResolveService<OpensslValidateCommonSecretHandler>();
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