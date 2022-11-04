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

    [DefaultValue("Amelit")]
    public string UserDisplayName { get; init; }

    [DefaultValue(5)]
    public DisplayNameColour UserDisplayNameColour { get; init; }

    [DefaultValue("Hello World!")]
    public string MessageText { get; init; }

    [DefaultValue("12:56")]
    public DateTime CreatedAt { get; init; }

    [DefaultValue("12:57")]
    public DateTime? UpdatedAt { get; init; }

    [DefaultValue(false)]
    public bool Self { get; init; }

    [DefaultValue("https://localhost:5001/Uploads/amelit_picture.jpg")]
    public string MessageAuthorPictureUrl { get; init; }

    [DefaultValue("https://localhost:5001/Uploads/message_attachment.pdf")]
    public string MessageAttachmentUrl { get; init; }

    [DefaultValue("John Doe")]
    public string InReplayToAuthor { get; init; }

    [DefaultValue("Hello world!")]
    public string InReplayToText { get; init; }
}

public static class MessageMapper
{
    public static Message ToMessage(this MessageEntity message, string displayName, Guid userId, string image, string mangoBlobAccess, int displayNameColour)
    {
        var messageDto = new Message
        {
            MessageId = message.Id,
            UserId = message.UserId,
            ChatId = message.ChatId,
            UserDisplayName = displayName,
            UserDisplayNameColour = (DisplayNameColour)displayNameColour,
            MessageText = message.Content,
            CreatedAt = message.CreatedAt,
            UpdatedAt = message.UpdatedAt,
            Self = message.UserId == userId,
            InReplayToAuthor = message.InReplayToAuthor,
            InReplayToText = message.InReplayToText,

            MessageAuthorPictureUrl = image != null
                ? $"{mangoBlobAccess}/{image}"
                : null,

            MessageAttachmentUrl = message.Attachment != null
                ? $"{mangoBlobAccess}/{message.Attachment}"
                : null,
        };

        return messageDto;
    }
}
