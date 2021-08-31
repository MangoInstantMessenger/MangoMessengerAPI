using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
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
