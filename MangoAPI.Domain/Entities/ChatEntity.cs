using System;
using System.Collections.Generic;
using MangoAPI.Domain.Enums;

namespace MangoAPI.Domain.Entities
{
    public sealed class ChatEntity
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public ChatType ChatType { get; set; }
        public string? Image { get; set; }
        public DateTime Created { get; set; }
        public int MembersCount { get; set; }

        public ICollection<MessageEntity> Messages { get; set; }
        public ICollection<UserChatEntity> ChatUsers { get; set; }
    }
}