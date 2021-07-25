using MangoAPI.Domain.Enums;

namespace MangoAPI.DTO.CommandModels.Chats
{
    public class CreateGroupCommandModel
    {
        public ChatType GroupType { get; set; }
        public string GroupTitle { get; set; }
        public string UserId { get; set; }
    }
}