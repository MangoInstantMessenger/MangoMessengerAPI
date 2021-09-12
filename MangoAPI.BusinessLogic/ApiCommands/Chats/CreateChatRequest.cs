using System;
using MangoAPI.BusinessLogic.Enums;
using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.Chats
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
                ChatType = request.ChatType,
                UserId = userId,
            };
        }
    }
}