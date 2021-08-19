namespace MangoAPI.BusinessLogic.ApiCommands.Chats
{
    using MangoAPI.Domain.Enums;
    using Newtonsoft.Json;

    public record CreateGroupRequest
    {
        [JsonConstructor]
        public CreateGroupRequest(ChatType groupType, string groupTitle)
        {
            GroupType = groupType;
            GroupTitle = groupTitle;
        }

        public ChatType GroupType { get; }
        public string GroupTitle { get; }
    }

    public static class CreateGroupCommandMapper
    {
        public static CreateGroupCommand ToCommand(this CreateGroupRequest model, string userId)
        {
            return new ()
            {
                GroupType = model.GroupType,
                GroupTitle = model.GroupTitle,
                UserId = userId,
            };
        }
    }
}
