#nullable enable

namespace MangoAPI.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using Enums;

    public sealed class ChatEntity
    {
        public string Id { get; set; } = null!;

        public string Title { get; set; } = null!;

        public ChatType ChatType { get; set; }

        public string? Image { get; set; }

        public DateTime Created { get; set; }

        public int MembersCount { get; set; }

        public ICollection<MessageEntity> Messages { get; set; } = null!;

        public ICollection<UserChatEntity> ChatUsers { get; set; } = null!;
    }
}
