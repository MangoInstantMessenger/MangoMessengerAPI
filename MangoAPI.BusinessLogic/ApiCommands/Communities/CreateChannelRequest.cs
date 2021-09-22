using System;
using System.ComponentModel;
using MangoAPI.BusinessLogic.Enums;
using MangoAPI.Domain.Enums;
using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities
{
    public record CreateChannelRequest
    {
        [JsonConstructor]
        public CreateChannelRequest(ChannelType channelType, string channelTitle, string channelDescription)
        {
            ChannelType = channelType;
            ChannelTitle = channelTitle;
            ChannelDescription = channelDescription;
        }

        [DefaultValue(4)]
        public ChannelType ChannelType { get; }
        
        [DefaultValue("Test Chat")]
        public string ChannelTitle { get; }
        
        [DefaultValue("Test Chat Public Group")]
        public string ChannelDescription { get; }
    }

    public static class CreateGroupCommandMapper
    {
        public static CreateChannelCommand ToCommand(this CreateChannelRequest request, Guid userId)
        {
            return new()
            {
                CommunityType = (CommunityType) request.ChannelType,
                ChannelTitle = request.ChannelTitle,
                ChannelDescription = request.ChannelDescription,
                UserId = userId
            };
        }
    }
}
