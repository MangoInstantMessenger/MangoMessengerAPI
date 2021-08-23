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
}
