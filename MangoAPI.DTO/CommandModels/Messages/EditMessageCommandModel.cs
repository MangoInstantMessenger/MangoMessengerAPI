namespace MangoAPI.DTO.CommandModels.Messages
{
    public class EditMessageCommandModel
    {
        public string MessageId { get; set; }
        public string UserId { get; set; }
        public string ModifiedText { get; set; }
    }
}