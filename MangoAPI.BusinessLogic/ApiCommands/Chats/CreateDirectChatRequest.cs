namespace MangoAPI.BusinessLogic.ApiCommands.Chats
{
    using Newtonsoft.Json;

    public record CreateDirectChatRequest
    {
        [JsonConstructor]
        public CreateDirectChatRequest(string partnerId)
        {
            PartnerId = partnerId;
        }

        public string PartnerId { get; }
    }
}
