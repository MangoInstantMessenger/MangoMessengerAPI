using System;
using MangoAPI.BusinessLogic.ApiCommands.Communities;
using MangoAPI.BusinessLogic.ApiCommands.Contacts;
using MangoAPI.BusinessLogic.ApiCommands.DiffieHellmanKeyExchanges;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.Domain.Enums;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.IntegrationTests.Helpers;

public static class CommandHelper
{
    public static RegisterCommand RegisterKhachaturCommand()
    {
        var command = new RegisterCommand(
            "Khachatur",
            "Bm3-`dPRv-/w#3)cw^97");

        return command;
    }

    public static RegisterCommand RegisterPetroCommand()
    {
        var command = new RegisterCommand(
            "PetroKolosov",
            "Bm3-`dPRv-/w#3)cw^97");

        return command;
    }

    public static CreateChannelCommand CreateExtremeCodeMainChatCommand(Guid userId)
    {
        var command = new CreateChannelCommand(
            ChannelTitle: "ExtremeCode Main",
            ChannelDescription: "Extreme Code Main Public Group",
            UserId: userId);

        return command;
    }

    public static AddContactCommand CreateContactCommand(Guid userId, Guid contactId)
    {
        var command = new AddContactCommand(
            userId,
            contactId);

        return command;
    }

    public static SendMessageCommand SendMessageToChannelCommand(Guid userId, Guid chatId, IFormFile attachment = null)
    {
        var command = new SendMessageCommand(
            Text: "test message",
            UserId: userId,
            ChatId: chatId,
            InReplyToUser: " ",
            InReplyToText: " ",
            Attachment: attachment);

        return command;
    }

    public static LoginCommand CreateLoginCommand(string username, string password)
    {
        var command = new LoginCommand(
            username,
            password);

        return command;
    }

    public static CreateKeyExchangeCommand CreateOpenSslCreateKeyExchangeCommand(
        Guid receiverId,
        Guid senderId,
        IFormFile senderPublicKey)
    {
        var command = new CreateKeyExchangeCommand(
            receiverId,
            senderId,
            senderPublicKey,
            KeyExchangeType.OpenSsl);

        return command;
    }

    public static ConfirmKeyExchangeCommand CreateOpenSslConfirmKeyExchangeCommand(
        Guid requestId, Guid userId, IFormFile receiverPublicKey)
    {
        var command = new ConfirmKeyExchangeCommand(
            requestId,
            userId,
            receiverPublicKey);

        return command;
    }

    public static CreateDiffieHellmanParameterCommand CreateOpenSslCreateDiffieHellmanParameterCommand(
        IFormFile diffieHellmanParameter, Guid userId)
    {
        var command = new CreateDiffieHellmanParameterCommand(
            diffieHellmanParameter,
            userId);

        return command;
    }
}