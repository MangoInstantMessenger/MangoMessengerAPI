using System;
using MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;
using MangoAPI.BusinessLogic.ApiCommands.Communities;
using MangoAPI.BusinessLogic.ApiCommands.Contacts;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.ApiCommands.Users;

namespace MangoAPI.IntegrationTests.Helpers;

public class CommandHelper
{
    public static RegisterCommand RegisterKhachaturCommand()
    {
        var command = new RegisterCommand(
            email: "xachulxx@gmail.com",
            displayName: "Khachatur Khachatryan",
            password: "Bm3-`dPRv-/w#3)cw^97",
            termsAccepted: true);

        return command;
    }

    public static RegisterCommand RegisterPetroCommand()
    {
        var command = new RegisterCommand(
            email: "kolosovp95@gmail.com",
            displayName: "Petro Kolosov",
            password: "Bm3-`dPRv-/w#3)cw^97",
            termsAccepted: true);

        return command;
    }

    public static CreateChannelCommand CreateExtremeCodeMainChatCommand(Guid userId)
    {
        var command = new CreateChannelCommand(
            channelTitle: "ExtremeCode Main",
            channelDescription: "Extreme Code Main Public Group",
            userId: userId);

        return command;
    }

    public static CngCreateKeyExchangeRequestCommand CreateCngKeyExchangeCommand(Guid userId, Guid requestedUserId)
    {
        var command = new CngCreateKeyExchangeRequestCommand(
            userId: userId,
            requestedUserId: requestedUserId,
            publicKey: "Public Key");

        return command;
    }

    public static AddContactCommand CreateContactCommand(Guid userId, Guid contactId)
    {
        var command = new AddContactCommand(
            userId: userId,
            contactId: contactId);
        
        return command;
    }

    public static SendMessageCommand SendMessageToChannelCommand(Guid userId, Guid chatId)
    {
        var command = new SendMessageCommand(
            userId: userId,
            chatId: chatId);

        return command;
    }

    public static VerifyEmailCommand CreateVerifyEmailCommand(string email, Guid emailCode)
    {
        var command = new VerifyEmailCommand(
            email: email,
            emailCode: emailCode);

        return command;
    }

    public static LoginCommand CreateLoginCommand(string email, string password)
    {
        var command = new LoginCommand(
            email: email,
            password: password);

        return command;
    }

    public static RequestPasswordRestoreCommand CreateRequestPasswordRestoreCommand(string email)
    {
        var command = new RequestPasswordRestoreCommand(email);

        return command;
    }
}