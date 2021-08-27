namespace MangoAPI.BusinessLogic.ApiCommands.Contacts
{
    using Newtonsoft.Json;

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
