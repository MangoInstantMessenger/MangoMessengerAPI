using System;
using MangoAPI.BusinessLogic.Enums;
using MangoAPI.Domain.Enums;
using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities
{
    public record CreateChatRequest
    {
        [JsonConstructor]
        public CreateChatRequest(Guid partnerId, ChatType chatType)
        {
            PartnerId = partnerId;
            ChatType = chatType;
        }

        public Guid PartnerId { get; }

        public ChatType ChatType { get; }
    }

    public static class CreateDirectChatRequestMapper
    {
        public static CreateChatCommand ToCommand(this CreateChatRequest request, Guid userId)
        {
            return new()
            {
                PartnerId = request.PartnerId,
                CommunityType = (CommunityType)request.ChatType,
                UserId = userId,
            };
        }
    }
}