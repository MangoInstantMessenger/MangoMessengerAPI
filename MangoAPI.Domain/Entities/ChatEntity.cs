using System;
using System.Collections.Generic;
using MangoAPI.Domain.Enums;

namespace MangoAPI.Domain.Entities
{
    public sealed class ChatEntity
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public int CommunityType { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public int MembersCount { get; set; }

        public ICollection<MessageEntity> Messages { get; set; }

        public ICollection<UserChatEntity> ChatUsers { get; set; }
    }
}