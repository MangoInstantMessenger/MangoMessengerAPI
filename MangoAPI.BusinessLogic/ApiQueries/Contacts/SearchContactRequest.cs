using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiQueries.Contacts
{
    public record SearchContactRequest
    {
        public string SearchQuery { get; }

        [JsonConstructor]
        public SearchContactRequest(string searchQuery)
        {
            SearchQuery = searchQuery;
        }
    }

    public static class SearchContactRequestMapper
    {
        public static SearchContactQuery ToCommand(this SearchContactRequest request, string userId)
        {
            return new()
            {
                SearchQuery = request.SearchQuery,
                UserId = userId,
            };
        }
    }
}