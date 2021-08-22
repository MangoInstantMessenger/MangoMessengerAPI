using MangoAPI.Domain.Enums;

namespace MangoAPI.BusinessLogic.Models
{
    public record Chat
    {
        public string ChatId { get; init; }

        public string Title { get; init; }

        public ChatType ChatType { get; init; }

        public string Image { get; init; }

        public string LastMessageAuthor { get; init; }

        public string LastMessage { get; init; }

        public string LastMessageAt { get; init; }

        public int MembersCount { get; init; }
    }
}