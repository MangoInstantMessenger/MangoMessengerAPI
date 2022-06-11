using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.DiffieHellmanLibrary.CngHandlers;
using MangoAPI.DiffieHellmanLibrary.Constants;
using MangoAPI.DiffieHellmanLibrary.Helpers;

namespace MangoAPI.DiffieHellmanConsole.Controllers;

public static class CngController
{
    public static async Task FetchCngHandler(IReadOnlyList<string> args, string method)
    {
        switch (method)
        {
            case Commands.CngGeneratePrivateKey:
            {
                var receiverIdString = args[1];
                var receiverId = GuidHelper.GetGuidValue(receiverIdString);
                var handler = DependencyResolver.ResolveService<CngGeneratePrivateKeyHandler>();
                await handler.GeneratePrivateKeyAsync(receiverId);
                break;
            }
            case Commands.CngCreateKeyExchange:
            {
                var receiverIdString = args[1];
                var receiverId = GuidHelper.GetGuidValue(receiverIdString);
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
                var requestId = GuidHelper.GetGuidValue(requestIdString);
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
                var partnerId = GuidHelper.GetGuidValue(requestIdString);
                var actor = actorString == "--sender" ? Actor.Sender : Actor.Receiver;
                var handler = DependencyResolver.ResolveService<CngCreateCommonSecretHandler>();
                await handler.CreateCommonSecretAsync(actor, partnerId);
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