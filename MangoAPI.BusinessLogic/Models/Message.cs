namespace MangoAPI.BusinessLogic.Models
{
    public record Message
    {
        public string MessageId { get; init; }

        public string UserDisplayName { get; init; }

        public string MessageText { get; init; }

        public string SentAt { get; init; }

        public string EditedAt { get; init; }

        public bool Self { get; init; }
    }
}