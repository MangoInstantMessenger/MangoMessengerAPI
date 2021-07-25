using MangoAPI.DTO.ApiCommands.Chats;

namespace MangoAPI.DTO.RequestModels.Chats
{
    public class CreateDirectChatRequest
    {
        public string PartnerId { get; set; }
    }

    public static class CreateDirectChatCommandMapper
    {
        public static CreateDirectChatCommand ToCommand(this CreateDirectChatRequest model) =>
            new()
            {
                PartnerId = model.PartnerId
            };
    }
}