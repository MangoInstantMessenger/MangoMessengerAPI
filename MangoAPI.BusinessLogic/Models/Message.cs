using System;

namespace MangoAPI.BusinessLogic.Models
{
    public record Message
    {
        public Guid MessageId { get; init; }

        public string UserDisplayName { get; init; }

        public string MessageText { get; init; }

        public string CreatedAt { get; init; }

        public string UpdatedAt { get; init; }

        public bool Self { get; init; }

        public bool IsEncrypted { get; init; }

        public int AuthorPublicKey { get; init; }

        public string PictureUrl { get; init; }
    }
}