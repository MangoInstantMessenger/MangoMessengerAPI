using MangoAPI.DTO.ApiCommands.Chats;

namespace MangoAPI.DTO.CommandModels.Chats
{
    public class CreateDirectChatCommandModel
    {
        public string PartnerId { get; set; }
    }

    public static class CreateDirectChatCommandMapper
    {
        public static CreateDirectChatCommand ToCreateDirectChatCommand(this CreateDirectChatCommandModel model) =>
            new CreateDirectChatCommand()
            {
                PartnerId = model.PartnerId
            };
    }
}