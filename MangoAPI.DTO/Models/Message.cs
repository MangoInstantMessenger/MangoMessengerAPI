using System;

namespace MangoAPI.DTO.Models
{
    public class Message
    {
        public string UserDisplayName { get; set; }
        public string MessageText { get; set; }
        public DateTime SentAt { get; set; }
        public DateTime? EditedAt { get; set; }
    }
}