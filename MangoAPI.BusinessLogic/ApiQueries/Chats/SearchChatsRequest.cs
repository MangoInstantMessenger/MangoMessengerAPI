namespace MangoAPI.BusinessLogic.ApiQueries.Chats
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
