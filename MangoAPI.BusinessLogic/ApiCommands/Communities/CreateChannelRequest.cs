﻿using System.ComponentModel;
using System.Text.Json.Serialization;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities;

public record CreateChannelRequest
{
    [JsonConstructor]
    public CreateChannelRequest(string channelTitle, string channelDescription)
    {
        ChannelTitle = channelTitle;
        ChannelDescription = channelDescription;
    }

    [DefaultValue("Test Chat")] public string ChannelTitle { get; }

    [DefaultValue("Test Chat Public Group")]
    public string ChannelDescription { get; }
}