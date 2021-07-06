using System;
using System.Collections.Generic;
using MangoAPI.Domain.Enums;

namespace MangoAPI.Domain.Entities
{
    public class ChatEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ChatType ChatType { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Tag { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public int MembersCount => ChatUsers.Count;

        public virtual ICollection<MessageEntity> Messages { get; set; }
        public virtual ICollection<UserChatEntity> ChatUsers { get; set; }
    }
}