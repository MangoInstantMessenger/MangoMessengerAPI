using System.Collections.Generic;

namespace MangoAPI.DTO.Models
{
    public record UserChat
    {
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string ChatId { get; init; }

        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string Title { get; init; }

        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string Image { get; init; }

        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string LastMessageAuthor { get; init; }

        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string LastMessage { get; init; }

        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string LastMessageAt { get; init; }

        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public int MembersCount { get; init; }

        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public bool IsMember { get; init; }
    }
}