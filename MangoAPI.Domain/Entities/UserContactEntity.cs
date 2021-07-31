namespace MangoAPI.Domain.Entities
{
    public class UserContactEntity
    {
        public string Id { get; set; }
        public string? ContactId { get; set; }
        public string? UserId { get; set; }

        public UserEntity User { get; set; }
    }
}