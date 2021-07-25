using MangoAPI.DTO.ApiCommands.Chats;

namespace MangoAPI.DTO.RequestModels.Chats
{
    public class JoinChatRequest
    {
        public string ChatId { get; set; }
    }

    public static class JoinChatCommandMapper
    {
        public static JoinChatCommand ToCommand(this JoinChatRequest model) =>
            new()
            {
                ChatId = model.ChatId
            };
    }
}