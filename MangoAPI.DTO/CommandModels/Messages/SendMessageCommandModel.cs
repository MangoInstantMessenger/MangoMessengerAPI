namespace MangoAPI.DTO.CommandModels.Messages
{
    public class SendMessageCommandModel
    {
        public string MessageText { get; set; }
        public string UserId { get; set; }
        public string ChatId { get; set; }
    }
}