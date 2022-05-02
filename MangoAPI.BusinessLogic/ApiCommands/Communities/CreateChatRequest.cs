using System;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities;

public record CreateChatRequest
{
    [JsonConstructor]
    public CreateChatRequest(Guid partnerId)
    {
        PartnerId = partnerId;
    }

    [DefaultValue("bd06f62e-87de-4ca4-a683-fad97cd8ac9f")]
    public Guid PartnerId { get; }
}