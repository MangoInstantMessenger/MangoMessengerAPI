using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiQueries.Users
{
    public record SearchContactByDisplayNameRequest
    {
        public string DisplayName { get; }

        [JsonConstructor]
        public SearchContactByDisplayNameRequest(string displayName)
        {
            DisplayName = displayName;
        }
    }

    public static class SearchContactByDisplayNameRequestMapper
    {
        public static SearchContactByDisplayNameQuery ToCommand(this SearchContactByDisplayNameRequest request, string userId)
        {
            return new()
            {
                DisplayName = request.DisplayName,
                UserId = userId,
            };
        }
    }
}