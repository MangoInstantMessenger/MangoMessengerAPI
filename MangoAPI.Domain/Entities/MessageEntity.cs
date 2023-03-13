using FluentValidation;
using System;

namespace MangoAPI.Domain.Entities;

public sealed class MessageEntity
{
    public Guid Id { get; private set; }

    public Guid UserId { get; private set; }

    public Guid ChatId { get; private set; }

    public string Text { get; private set; }

    public string InReplyToUser { get; private set; }

    public string InReplyToText { get; private set; }

    public string AttachmentFileName { get; private set; }

    public DateTime CreatedAt { get; private set; }

    public DateTime? UpdatedAt { get; private set; }

    public UserEntity User { get; set; }

    public ChatEntity Chat { get; set; }

    private MessageEntity()
    {
    }
    
    private MessageEntity(Guid userId, Guid chatId, string text)
    {
        Id = Guid.NewGuid();
        UserId = userId;
        ChatId = chatId;
        Text = text;
        CreatedAt = DateTime.UtcNow;

        new MessageEntityValidator().ValidateAndThrow(this);
    }

    private MessageEntity(
        Guid userId,
        Guid chatId,
        string text,
        string inReplyToUser,
        string inReplyToText,
        string attachmentFileName) : this(userId, chatId, text)
    {
        CreatedAt = DateTime.UtcNow;
        InReplyToUser = inReplyToUser;
        InReplyToText = inReplyToText;
        AttachmentFileName = attachmentFileName;

        new MessageEntityValidator().ValidateAndThrow(this);
    }

    public static MessageEntity Create(
        Guid userId,
        Guid chatId,
        string text,
        string inReplyToUser,
        string inReplyToText,
        string attachmentFileName)
    {
        var message = new MessageEntity(
            userId,
            chatId,
            text,
            inReplyToUser,
            inReplyToText,
            attachmentFileName);

        return message;
    }

    public static MessageEntity Create(Guid userId, Guid chatId, string text)
    {
        var message = new MessageEntity(userId, chatId, text);

        return message;
    }

    public void UpdateMessageText(string text)
    {
        Text = text;
        UpdatedAt = DateTime.UtcNow;

        new MessageEntityValidator().ValidateAndThrow(this);
    }
}