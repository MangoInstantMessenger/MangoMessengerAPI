namespace MangoAPI.DTO.Models
{
    public record Message
    {
        public string MessageId { get; set; }
        public string UserDisplayName { get; set; }
        public string MessageText { get; set; }
        public string SentAt { get; set; }
        public string EditedAt { get; set; }
        public bool Self { get; set; }
    }
}