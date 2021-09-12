using System;
using MangoAPI.BusinessLogic.Enums;
using MangoAPI.Domain.Enums;
using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.Chats
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

        public ChannelType ChannelType { get; }
        public string ChannelTitle { get; }
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
