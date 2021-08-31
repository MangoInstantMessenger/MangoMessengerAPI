using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.Contacts
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
}
