using Newtonsoft.Json;

namespace MangoAPI.DTO.ApiCommands.Contacts
{
    public record AddContactRequest
    {
        [JsonConstructor]
        public AddContactRequest(string contactId)
        {
            ContactId = contactId;
        }
        
        public string ContactId { get; }
    }

    public static class AddContactRequestMapper
    {
        public static AddContactCommand ToCommand(this AddContactRequest model, string userId) => new()
            {
                ContactId = model.ContactId,
                UserId = userId
            };
    }
}