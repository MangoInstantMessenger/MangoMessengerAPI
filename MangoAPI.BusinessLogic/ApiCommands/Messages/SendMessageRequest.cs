using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages;

public class SendMessageRequest
{
    [DefaultValue("hello world")] public string Text { get; set; }

    [DefaultValue("a8747c37-c5ef-4a87-943c-3ee3ae0a2871")]
    public Guid ChatId { get; set; }

    [DefaultValue("John Doe")] public string InReplyToUser { get; set; }

    [DefaultValue("Hello world!")] public string InReplyToText { get; set; }

    [DefaultValue("2021-08-01T00:00:00.0000000")]
    public DateTime? CreatedAt { get; set; }

    public IFormFile Attachment { get; set; }
}