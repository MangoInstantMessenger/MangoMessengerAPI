using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiQueries.Chats
{
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
