using System;
using MangoAPI.Domain.Enums;

namespace MangoAPI.Domain.Entities
{
    public sealed class UserChatEntity
    {
        public Guid UserId { get; set; }

        public Guid ChatId { get; set; }

        public UserRole RoleId { get; set; }

        public bool IsArchived { get; set; }

        public UserEntity User { get; set; }

        public ChatEntity Chat { get; set; }
    }
}