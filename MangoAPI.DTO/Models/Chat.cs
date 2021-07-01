using System.Collections.Generic;

namespace MangoAPI.DTO.Models
{
    public class Chat
    {
        public string Title { get; set; }
        public string Tag { get; set; }
        public string Image { get; set; }

        public List<Message> Messages { get; set; }
    }
}