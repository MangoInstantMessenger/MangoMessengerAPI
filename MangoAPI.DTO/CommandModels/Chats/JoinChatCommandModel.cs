using MangoAPI.DTO.ApiCommands.Chats;

namespace MangoAPI.DTO.CommandModels.Chats
{
    public class JoinChatCommandModel
    {
        public string ChatId { get; set; }
    }

    public static class JoinChatCommandMapper
    {
        public static JoinChatCommand ToJoinChatCommand(this JoinChatCommandModel model) =>
            new()
            {
                ChatId = model.ChatId
            };
    }
}