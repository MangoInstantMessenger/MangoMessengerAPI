using System;

namespace MangoAPI.Domain.Entities
{
    public sealed class MessageEntity
    {
        public string Id { get; set; }

        public string UserId { get; set; }

        public string ChatId { get; set; }

        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public UserEntity User { get; set; }

        public ChatEntity Chat { get; set; }
    }
}
