using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.Chats
{
    public record CreateDirectChatRequest
    {
        [JsonConstructor]
        public CreateDirectChatRequest(string partnerId)
        {
            PartnerId = partnerId;
        }

        public string PartnerId { get; }
    }

    public static class CreateDirectChatCommandMapper
    {
        public static CreateDirectChatCommand ToCommand(this CreateDirectChatRequest model, string userId) =>
            new()
            {
                PartnerId = model.PartnerId,
                UserId = userId
            };
    }
}