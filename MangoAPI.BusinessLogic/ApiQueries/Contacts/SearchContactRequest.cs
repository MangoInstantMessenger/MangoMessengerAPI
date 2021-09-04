using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiQueries.Contacts
{
    public record SearchContactRequest
    {
        public string Data { get; }

        [JsonConstructor]
        public SearchContactRequest(string data)
        {
            Data = data;
        }
    }

    public static class SearchContactRequestMapper
    {
        public static SearchContactQuery ToCommand(this SearchContactRequest request, string userId)
        {
            return new()
            {
                Data = request.Data,
                UserId = userId,
            };
        }
    }
}