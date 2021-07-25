using System;
using System.Collections.Generic;
using MangoAPI.Domain.Enums;

namespace MangoAPI.Domain.Entities
{
    public class ChatEntity
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public ChatType ChatType { get; set; }
        public string Image { get; set; }
        public DateTime Created { get; set; }
        public int MembersCount { get; set; }
        
        public virtual ICollection<MessageEntity> Messages { get; set; }
        public virtual ICollection<UserChatEntity> ChatUsers { get; set; }
    }
}