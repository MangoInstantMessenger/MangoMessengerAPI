using System;
using System.ComponentModel;
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

        [DefaultValue("bd06f62e-87de-4ca4-a683-fad97cd8ac9f")]
        public Guid PartnerId { get; }

        [DefaultValue(1)]
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