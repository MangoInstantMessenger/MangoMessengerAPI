namespace MangoAPI.DTO.Models
{
    public class Message
    {
        public string UserDisplayName { get; set; }
        public string MessageText { get; set; }
        public string SentAt { get; set; }
        public string EditedAt { get; set; }
        public bool Self { get; set; }
    }
}