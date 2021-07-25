using System;

namespace MangoAPI.Domain.Entities
{
    public class MessageEntity
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string ChatId { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual UserEntity User { get; set; }
        public virtual ChatEntity Chat { get; set; }
    }
}