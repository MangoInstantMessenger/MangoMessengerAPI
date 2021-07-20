using System;

namespace MangoAPI.DTO.Models
{
    public class UserChat
    {
        public int ChatId { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string LastMessageAuthor { get; set; }
        public string LastMessage { get; set; }
        public DateTime? LastMessageAt { get; set; }
    }
}