using System;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages;

public record EditMessageRequest
{
    [JsonConstructor]
    public EditMessageRequest(Guid messageId, string modifiedText, Guid chatId)
    {
        MessageId = messageId;
        ModifiedText = modifiedText;
        ChatId = chatId;
    }

    [DefaultValue("c5a73134-434f-4ce8-bd91-d945e15673c5")]
    public Guid MessageId { get; }

    [DefaultValue("test message")]
    public string ModifiedText { get; }

    [DefaultValue("be82e6cd-e00c-4929-b707-55580c5d69e0")]
    public Guid ChatId { get; }
}