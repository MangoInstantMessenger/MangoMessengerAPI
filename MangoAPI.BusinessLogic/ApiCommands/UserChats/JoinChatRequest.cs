namespace MangoAPI.BusinessLogic.ApiCommands.UserChats
{
    using Newtonsoft.Json;

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
