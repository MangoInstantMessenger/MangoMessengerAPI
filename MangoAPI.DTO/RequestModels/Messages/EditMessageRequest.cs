using MangoAPI.DTO.ApiCommands.Messages;

namespace MangoAPI.DTO.RequestModels.Messages
{
    public class EditMessageRequest
    {
        public string MessageId { get; set; }
        public string ModifiedText { get; set; }
    }

    public static class EditMessageCommandMapper
    {
        public static EditMessageCommand ToCommand(this EditMessageRequest model) =>
            new()
            {
                MessageId = model.MessageId,
                ModifiedText = model.ModifiedText
            };
    }
}