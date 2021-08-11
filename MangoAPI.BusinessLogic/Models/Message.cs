namespace MangoAPI.DTO.Models
{
    public record Message
    {
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string UserDisplayName { get; init; }

        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string MessageText { get; init; }

        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string SentAt { get; init; }

        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string EditedAt { get; init; }

        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public bool Self { get; init; }
    }
}