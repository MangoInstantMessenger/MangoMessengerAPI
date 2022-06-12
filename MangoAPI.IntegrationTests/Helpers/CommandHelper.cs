using System;
using MangoAPI.BusinessLogic.ApiCommands.Communities;
using MangoAPI.BusinessLogic.ApiCommands.Contacts;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.BusinessLogic.ApiCommands.OpenSslKeyExchange;
using MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.IntegrationTests.Helpers;

public static class CommandHelper
{
    public static RegisterCommand RegisterKhachaturCommand()
    {
        var command = new RegisterCommand(
            Email: "xachulxx@gmail.com",
            DisplayName: "Khachatur Khachatryan",
            Password: "Bm3-`dPRv-/w#3)cw^97",
            TermsAccepted: true);

        return command;
    }

    public static RegisterCommand RegisterPetroCommand()
    {
        var command = new RegisterCommand(
            Email: "kolosovp95@gmail.com",
            DisplayName: "Petro Kolosov",
            Password: "Bm3-`dPRv-/w#3)cw^97",
            TermsAccepted: true);

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
            UserId: userId,
            ContactId: contactId);

        return command;
    }

    public static SendMessageCommand SendMessageToChannelCommand(Guid userId, Guid chatId)
    {
        var command = new SendMessageCommand(
            MessageText: "test message",
            UserId: userId,
            ChatId: chatId,
            AttachmentUrl: " ",
            InReplayToAuthor: " ",
            InReplayToText: " ");

        return command;
    }

    public static VerifyEmailCommand CreateVerifyEmailCommand(string email, Guid emailCode)
    {
        var command = new VerifyEmailCommand(
            Email: email,
            EmailCode: emailCode);

        return command;
    }

    public static LoginCommand CreateLoginCommand(string email, string password)
    {
        var command = new LoginCommand(
            Email: email,
            Password: password);

        return command;
    }

    public static RequestPasswordRestoreCommand CreateRequestPasswordRestoreCommand(string email)
    {
        var command = new RequestPasswordRestoreCommand(email);

        return command;
    }

    public static OpenSslCreateKeyExchangeCommand CreateOpenSslCreateKeyExchangeCommand(Guid userId, Guid receiverId, IFormFile senderPublicKey)
    {
        var command = new OpenSslCreateKeyExchangeCommand(
            SenderId: userId,
            ReceiverId: receiverId,
            SenderPublicKey: senderPublicKey);

        return command;
    }

    public static OpenSslConfirmKeyExchangeCommand CreateOpenSslConfirmKeyExchangeCommand(
        Guid requestId, Guid userId, IFormFile receiverPublicKey)
    {
        var command = new OpenSslConfirmKeyExchangeCommand(
            RequestId: requestId,
            UserId: userId,
            ReceiverPublicKey: receiverPublicKey);

        return command;
    }

    public static OpenSslCreateDiffieHellmanParameterCommand CreateOpenSslCreateDiffieHellmanParameterCommand(
        IFormFile diffieHellmanParameter, Guid userId)
    {
        var command = new OpenSslCreateDiffieHellmanParameterCommand(
            DiffieHellmanParameter: diffieHellmanParameter,
            UserId: userId);

        return command;
    }
}