using Microsoft.AspNetCore.Http;
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
        string inReplayToAuthor,
        string inReplayToText,
        DateTime? createdAt,
        Guid? messageId,
        IFormFile attachment)
    {
        MessageText = messageText;
        ChatId = chatId;
        InReplayToAuthor = inReplayToAuthor;
        InReplayToText = inReplayToText;
        CreatedAt = createdAt;
        MessageId = messageId;
        Attachment = attachment;
    }

    [DefaultValue("hello world")]
    public string MessageText { get; }

    [DefaultValue("a8747c37-c5ef-4a87-943c-3ee3ae0a2871")]
    public Guid ChatId { get; }

    [DefaultValue("John Doe")]
    public string InReplayToAuthor { get; }

    [DefaultValue("Hello world!")]
    public string InReplayToText { get; }

    [DefaultValue("2021-08-01T00:00:00.0000000")]
    public DateTime? CreatedAt { get; }

    [DefaultValue("f56ac722-a57b-411c-8306-c2e05fb1a8df")]
    public Guid? MessageId { get; }
    
    public IFormFile Attachment { get; }
}
