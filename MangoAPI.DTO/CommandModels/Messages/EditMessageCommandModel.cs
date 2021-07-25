using MangoAPI.DTO.ApiCommands.Messages;

namespace MangoAPI.DTO.CommandModels.Messages
{
    public class EditMessageCommandModel
    {
        public string MessageId { get; set; }
        public string ModifiedText { get; set; }
    }

    public static class EditMessageCommandMapper
    {
        public static EditMessageCommand ToEditMessageCommand(this EditMessageCommandModel model) =>
            new()
            {
                MessageId = model.MessageId,
                ModifiedText = model.ModifiedText
            };
    }
}