using MangoAPI.Domain.Entities;
using System;

namespace MangoAPI.UnitTests.Helpers;

public static class MessageEntityHelper
{
    private static MessageEntity CreateBase(
        Guid userId,
        Guid chatId,
        string text = "Test text",
        string inReplyToUser = "ReplyUser",
        string inReplyToText = "Reply text",
        string attachmentFileName = "file123.txt")
    {
        var message = MessageEntity.Create(userId, chatId, text, inReplyToUser, inReplyToText, attachmentFileName);

        return message;
    }

    public static MessageEntity CreateSuccess()
    {
        var userId = Guid.NewGuid();
        var chatId = Guid.NewGuid();

        return CreateBase(userId, chatId);
    }

    public static MessageEntity CreateWithUserId(Guid userId)
    {
        var chatId = Guid.NewGuid();
        return CreateBase(userId, chatId);
    }

    public static MessageEntity CreateWithChatId(Guid chatId)
    {
        var userId = Guid.NewGuid();
        return CreateBase(userId, chatId);
    }

    public static MessageEntity CreateWithText(string messageText)
    {
        var userId = Guid.NewGuid();
        var chatId = Guid.NewGuid();

        return CreateBase(userId, chatId, text: messageText);
    }

    public static MessageEntity CreateWithInReplyToUser(string inReplyToUser)
    {
        var userId = Guid.NewGuid();
        var chatId = Guid.NewGuid();

        return CreateBase(userId, chatId, inReplyToUser: inReplyToUser);
    }

    public static MessageEntity CreateWithInReplyToText(string inReplyToText)
    {
        var userId = Guid.NewGuid();
        var chatId = Guid.NewGuid();

        return CreateBase(userId, chatId, inReplyToText: inReplyToText);
    }

    public static MessageEntity CreateWithAttachmentFileName(string attachmentFileName)
    {
        var userId = Guid.NewGuid();
        var chatId = Guid.NewGuid();

        return CreateBase(userId, chatId, attachmentFileName: attachmentFileName);
    }
}