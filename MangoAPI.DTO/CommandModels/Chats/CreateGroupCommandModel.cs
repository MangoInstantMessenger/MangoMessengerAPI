using MangoAPI.Domain.Enums;
using MangoAPI.DTO.ApiCommands.Chats;

namespace MangoAPI.DTO.CommandModels.Chats
{
    public class CreateGroupCommandModel
    {
        public ChatType GroupType { get; set; }
        public string GroupTitle { get; set; }
    }

    public static class CreateGroupCommandMapper
    {
        public static CreateGroupCommand ToCreateGroupCommand(this CreateGroupCommandModel model) =>
            new()
            {
                GroupType = model.GroupType,
                GroupTitle = model.GroupTitle
            };
    }
}