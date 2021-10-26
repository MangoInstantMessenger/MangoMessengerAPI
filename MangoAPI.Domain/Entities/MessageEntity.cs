using System;

namespace MangoAPI.Domain.Entities
{
    public sealed class MessageEntity
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid ChatId { get; set; }

        public string Content { get; set; }

        public string InReplayToAuthor { get; set; }

        public string InReplayToText { get; set; }

        public string Attachment { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public UserEntity User { get; set; }

        public ChatEntity Chat { get; set; }
    }
}
