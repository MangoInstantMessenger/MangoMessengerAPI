using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.DiffieHellmanLibrary.Constants;
using MangoAPI.DiffieHellmanLibrary.Helpers;
using MangoAPI.DiffieHellmanLibrary.OpenSslHandlers;

namespace MangoAPI.DiffieHellmanConsole.Controllers;

public static class OpenSslController
{
    public static async Task FetchOpenSslHandlerAsync(IReadOnlyList<string> args, string method)
    {
        switch (method)
        {
            case Commands.OpenSslGenerateDhParameters:
                {
                    await OpenSslGenerateDhParametersHandler.CreateDhParametersAsync();
                    break;
                }

            case Commands.OpenSslUploadDhParameters:
                {
                    var handler = DependencyResolver.ResolveService<OpensslUploadDhParametersHandler>();
                    await handler.UploadDhParametersAsync();
                    break;
                }

            case Commands.OpenSslDownloadDhParameters:
                {
                    var handler = DependencyResolver.ResolveService<OpensslDownloadDhParametersHandler>();
                    await handler.DownloadDhParametersAsync();
                    break;
                }

            case Commands.OpenSslGeneratePrivateKey:
                {
                    var receiverIdString = args[1];
                    var receiverId = GuidHelper.GetGuidValue(receiverIdString);
                    var handler = DependencyResolver.ResolveService<OpensslGeneratePrivateKeyHandler>();
                    await handler.GeneratePrivateKeyAsync(receiverId);
                    break;
                }

            case Commands.OpenSslGeneratePublicKey:
                {
                    var receiverIdString = args[1];
                    var receiverId = GuidHelper.GetGuidValue(receiverIdString);
                    var handler = DependencyResolver.ResolveService<OpensslGeneratePublicKeyHandler>();
                    await handler.GeneratePublicKeyAsync(receiverId);

                    break;
                }

            case Commands.OpenSslCreateKeyExchange:
                {
                    var receiverIdString = args[1];
                    var receiverId = GuidHelper.GetGuidValue(receiverIdString);
                    var handler = DependencyResolver.ResolveService<OpensslCreateKeyExchangeHandler>();
                    await handler.CreateKeyExchangeAsync(receiverId);
                    break;
                }

            case Commands.OpenSslPrintKeyExchanges:
                {
                    var handler = DependencyResolver.ResolveService<OpensslPrintKeyExchangesHandler>();
                    await handler.PrintKeyExchangesAsync();
                    break;
                }

            case Commands.OpenSslConfirmKeyExchange:
                {
                    var userIdString = args[1];
                    var userId = GuidHelper.GetGuidValue(userIdString);
                    var handler = DependencyResolver.ResolveService<OpensslConfirmKeyExchangeHandler>();
                    await handler.ConfirmKeyExchangeAsync(userId);
                    break;
                }

            case Commands.OpenSslCreateCommonSecret:
                {
                    var actorString = args[1];
                    var requestIdString = args[2];
                    var partnerId = GuidHelper.GetGuidValue(requestIdString);
                    var actor = actorString == "--sender" ? Actor.Sender : Actor.Receiver;
                    var handler = DependencyResolver.ResolveService<OpensslCreateCommonSecretHandler>();
                    await handler.CreateCommonSecretAsync(actor, partnerId);
                    break;
                }

            case Commands.OpenSslDownloadPublicKey:
                {
                    var actorString = args[1];
                    var userIdString = args[2];
                    var userId = GuidHelper.GetGuidValue(userIdString);
                    var actor = actorString == "--sender" ? Actor.Sender : Actor.Receiver;
                    var handler = DependencyResolver.ResolveService<OpensslDownloadPublicKeyHandler>();
                    await handler.DownloadPublicKeyAsync(actor, userId);
                    break;
                }

            case Commands.OpenSslDeclineKeyExchange:
                {
                    var requestIdString = args[1];
                    var requestId = GuidHelper.GetGuidValue(requestIdString);
                    var handler = DependencyResolver.ResolveService<OpensslDeclineKeyExchangeHandler>();
                    await handler.DeclineKeyExchangeAsync(requestId);
                    break;
                }

            case Commands.OpenSslPrintKeyExchangeById:
                {
                    var requestIdString = args[1];
                    var requestId = GuidHelper.GetGuidValue(requestIdString);
                    var handler = DependencyResolver.ResolveService<OpensslPrintKeyExchangeByIdHandler>();
                    await handler.GetKeyExchangeByIdAsync(requestId);
                    break;
                }

            case Commands.OpensslValidateCommonSecret:
                {
                    var senderIdString = args[1];
                    var receiverIdString = args[2];
                    var senderId = GuidHelper.GetGuidValue(senderIdString);
                    var receiverId = GuidHelper.GetGuidValue(receiverIdString);
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
}