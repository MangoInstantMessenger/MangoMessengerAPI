namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    using Newtonsoft.Json;

    public record SendMessageRequest
    {
        [JsonConstructor]
        public SendMessageRequest(string messageText, string chatId)
        {
            MessageText = messageText;
            ChatId = chatId;
        }

        public string MessageText { get; }
        public string ChatId { get; }
    }

    public static class SendMessageCommandMapper
    {
        public static SendMessageCommand ToCommand(this SendMessageRequest model, string userId)
        {
            return new ()
            {
                ChatId = model.ChatId,
                MessageText = model.MessageText,
                UserId = userId,
            };
        }
    }
}
