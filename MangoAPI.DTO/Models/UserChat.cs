namespace MangoAPI.DTO.Models
{
    public class UserChat
    {
        public string ChatId { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string LastMessageAuthor { get; set; }
        public string LastMessage { get; set; }
        public string LastMessageAt { get; set; }
        public int MembersCount { get; set; }
        public bool IsMember { get; set; }
    }
}