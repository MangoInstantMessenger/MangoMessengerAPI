using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats
{
    public record JoinChatRequest
    {
        [JsonConstructor]
        public JoinChatRequest(string chatId)
        {
            ChatId = chatId;
        }

        public string ChatId { get; }
    }
}
