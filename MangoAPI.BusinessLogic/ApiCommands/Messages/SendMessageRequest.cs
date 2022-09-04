using System;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages;

public record SendMessageRequest
{
    [JsonConstructor]
    public SendMessageRequest(
        string messageText,
        Guid chatId,
        string attachmentUrl,
        string inReplayToAuthor,
        string inReplayToText,
        DateTime? createdAt,
        Guid? messageId)
    {
        MessageText = messageText;
        ChatId = chatId;
        AttachmentUrl = attachmentUrl;
        InReplayToAuthor = inReplayToAuthor;
        InReplayToText = inReplayToText;
        CreatedAt = createdAt;
        MessageId = messageId;
    }

    [DefaultValue("hello world")]
    public string MessageText { get; }

    [DefaultValue("a8747c37-c5ef-4a87-943c-3ee3ae0a2871")]
    public Guid ChatId { get; }

    [DefaultValue("https://localhost:5001/Uploads/khachatur_picture.jpg")]
    public string AttachmentUrl { get; }

    [DefaultValue("John Doe")]
    public string InReplayToAuthor { get; }

    [DefaultValue("Hello world!")]
    public string InReplayToText { get; }

    public DateTime? CreatedAt { get; }

    public Guid? MessageId { get; }
}
