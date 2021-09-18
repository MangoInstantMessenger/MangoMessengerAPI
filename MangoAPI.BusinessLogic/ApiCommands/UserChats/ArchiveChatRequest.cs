using System;
using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats
{
    public record ArchiveChatRequest
    {
        [JsonConstructor]
        public ArchiveChatRequest(Guid chatId, bool archived)
        {
            ChatId = chatId;
            Archived = archived;
        }

        public Guid ChatId { get; }
        public bool Archived { get; }
    }

    public static class ArchiveChatRequestMapper
    {
        public static ArchiveChatCommand ToCommand(this ArchiveChatRequest request, Guid userId)
        {
            return new()
            {
                ChatId = request.ChatId,
                UserId = userId,
                Archived = request.Archived,
            };
        }
    }
}