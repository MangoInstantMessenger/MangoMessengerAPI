using MangoAPI.Domain.Enums;

namespace MangoAPI.Domain.Entities
{
    public class UserChatEntity
    {
        private UserChatEntity(string userId, string chatId, UserRole roleId)
        {
            UserId = userId;
            ChatId = chatId;
            RoleId = roleId;
        }

        public string UserId { get; }
        public string ChatId { get; }
        public UserRole RoleId { get; }

        public static UserChatEntity Create(string userId, string chatId, UserRole roleId) =>
            new(userId, chatId, roleId);

        public UserEntity User { get; set; }
        public ChatEntity Chat { get; set; }
    }
}