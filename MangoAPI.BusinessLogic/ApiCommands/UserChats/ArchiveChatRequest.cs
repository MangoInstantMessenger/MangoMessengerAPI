namespace MangoAPI.BusinessLogic.ApiCommands.UserChats
{
    public record ArchiveChatRequest
    {
        public string ChatId { get; init; }
        public bool Archived { get; init; }
    }

    public static class ArchiveChatRequestMapper
    {
        public static ArchiveChatCommand ToCommand(this ArchiveChatRequest request, string userId)
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
