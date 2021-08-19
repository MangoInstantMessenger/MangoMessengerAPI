namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    using Newtonsoft.Json;

    public record DeleteMessageRequest
    {
        [JsonConstructor]
        public DeleteMessageRequest(string messageId)
        {
            MessageId = messageId;
        }

        public string MessageId { get; }
    }

    public static class DeleteMessageCommandMapper
    {
        public static DeleteMessageCommand ToCommand(this DeleteMessageRequest model, string userId)
        {
            return new ()
            {
                MessageId = model.MessageId,
                UserId = userId,
            };
        }
    }
}
