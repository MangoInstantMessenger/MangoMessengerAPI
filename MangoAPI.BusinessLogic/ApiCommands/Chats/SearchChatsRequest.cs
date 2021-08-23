namespace MangoAPI.BusinessLogic.ApiCommands.Chats
{
    using Newtonsoft.Json;

    public record SearchChatsRequest
    {
        [JsonConstructor]
        public SearchChatsRequest(string displayName)
        {
            DisplayName = displayName;
        }

        public string DisplayName { get; }
    }
}
