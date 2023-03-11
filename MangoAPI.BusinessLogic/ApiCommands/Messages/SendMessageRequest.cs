using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages;

public class SendMessageRequest
{
    [DefaultValue("hello world")]
    [JsonPropertyName("messageText")]
    public string MessageText { get; set; }

    [DefaultValue("a8747c37-c5ef-4a87-943c-3ee3ae0a2871")]
    [JsonPropertyName("chatId")]
    public Guid ChatId { get; set; }

    [DefaultValue("John Doe")]
    [JsonPropertyName("inReplayToAuthor")]
    public string InReplayToAuthor { get; set; }

    [DefaultValue("Hello world!")]
    [JsonPropertyName("inReplayToText")]
    public string InReplayToText { get; set; }

    [DefaultValue("2021-08-01T00:00:00.0000000")]
    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }

    [DefaultValue("f56ac722-a57b-411c-8306-c2e05fb1a8df")]
    [JsonPropertyName("messageId")]
    public Guid? MessageId { get; set; }

    public IFormFile Attachment { get; set; }
}