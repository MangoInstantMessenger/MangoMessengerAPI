using MangoAPI.Domain.Enums;
using MangoAPI.DTO.ApiCommands.Chats;

namespace MangoAPI.DTO.RequestModels.Chats
{
    public class CreateGroupRequest
    {
        public ChatType GroupType { get; set; }
        public string GroupTitle { get; set; }
    }

    public static class CreateGroupCommandMapper
    {
        public static CreateGroupCommand ToCommand(this CreateGroupRequest model) =>
            new()
            {
                GroupType = model.GroupType,
                GroupTitle = model.GroupTitle
            };
    }
}