using System;
using System.Collections.Generic;
using MangoAPI.Domain.Enums;

namespace MangoAPI.Domain.Entities
{
    public class ChatEntity
    {
        public int Id { get; set; }
        public string OwnerId { get; set; }
        public ChatType ChatType { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public virtual ICollection<MessageEntity> Messages { get; set; }
    }
}