using System;
using System.ComponentModel;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;

namespace MangoAPI.BusinessLogic.Models;

/// <summary>
/// Model used to display message in chat window.
/// </summary>
public record Message
{
    [DefaultValue("5547b250-4d14-4a4a-88fd-66a779d4f1d2")]
    public Guid MessageId { get; init; }

    [DefaultValue("00aed827-db8c-47de-bc81-78647030918f")]
    public Guid ChatId { get; init; }

    [DefaultValue("11aed827-db8a-47de-bc81-13337703091f")]
    public Guid UserId { get; init; }

    [DefaultValue("Amelit")] public string UserDisplayName { get; init; }

    [DefaultValue(5)] public DisplayNameColour UserDisplayNameColour { get; init; }

    [DefaultValue("Hello World!")] public string Text { get; init; }

    [DefaultValue("12:56")] public DateTime CreatedAt { get; init; }

    [DefaultValue("12:57")] public DateTime? UpdatedAt { get; init; }

    [DefaultValue(false)] public bool Self { get; init; }

    [DefaultValue("http://127.0.0.1:10000/devstoreaccount1/mangocontainer/animetyanpic8.jpg")]
    public string AuthorImageUrl { get; init; }

    [DefaultValue("http://127.0.0.1:10000/devstoreaccount1/mangocontainer/message_attachment.pdf")]
    public string AttachmentUrl { get; init; }

    [DefaultValue("John Doe")] public string InReplyToUser { get; init; }

    [DefaultValue("Hello world!")] public string InReplyToText { get; init; }
}

public static class MessageMapper
{
    public static Message ToMessage(
        this MessageEntity message,
        string displayName,
        Guid userId,
        DisplayNameColour displayNameColour,
        string authorPictureUrl,
        string attachmentUrl)
    {
        var messageDto = new Message
        {
            MessageId = message.Id,
            UserId = message.UserId,
            ChatId = message.ChatId,
            UserDisplayName = displayName,
            UserDisplayNameColour = displayNameColour,
            Text = message.Text,
            CreatedAt = message.CreatedAt,
            UpdatedAt = message.UpdatedAt,
            Self = message.UserId == userId,
            InReplyToUser = message.InReplyToUser,
            InReplyToText = message.InReplyToText,
            AuthorImageUrl = authorPictureUrl,
            AttachmentUrl = attachmentUrl
        };

        return messageDto;
    }
}