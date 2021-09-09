using System;
using MangoAPI.Domain.Enums;
using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.Chats
{
    public record CreateGroupRequest
    {
        [JsonConstructor]
        public CreateGroupRequest(ChatType groupType, string groupTitle,
            string groupDescription)
        {
            GroupType = groupType;
            GroupTitle = groupTitle;
            GroupDescription = groupDescription;
        }
        
        public ChatType GroupType { get; }
        public string GroupTitle { get; }
        public string GroupDescription { get; }
    }

    public static class CreateGroupCommandMapper
    {
        public static CreateGroupCommand ToCommand(this CreateGroupRequest model, Guid userId)
        {
            return new ()
            {
                GroupType = model.GroupType,
                GroupTitle = model.GroupTitle,
                GroupDescription = model.GroupDescription,
                UserId = userId
            };
        }
    }
}
