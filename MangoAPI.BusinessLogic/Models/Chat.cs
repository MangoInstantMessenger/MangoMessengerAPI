using System;
using MangoAPI.Domain.Enums;

namespace MangoAPI.BusinessLogic.Models
{
    public record Chat
    {
        public Guid ChatId { get; init; }

        public string Title { get; init; }

        public ChatType ChatType { get; init; }

        public string Image { get; init; }

        public string Description { get; init; }

        public int MembersCount { get; init; }

        public bool IsArchived { get; init; }

        public bool IsMember { get; init; }

        public Message LastMessage { get; init; }
    }
}