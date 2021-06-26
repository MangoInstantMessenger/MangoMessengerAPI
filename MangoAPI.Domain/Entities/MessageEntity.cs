using System;

namespace MangoAPI.Domain.Entities
{
    public class MessageEntity
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public virtual UserEntity User { get; set; }
    }
}