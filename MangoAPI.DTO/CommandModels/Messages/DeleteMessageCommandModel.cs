using MangoAPI.DTO.ApiCommands.Messages;

namespace MangoAPI.DTO.CommandModels.Messages
{
    public class DeleteMessageCommandModel
    {
        public string MessageId { get; set; }
    }

    public static class DeleteMessageCommandMapper
    {
        public static DeleteMessageCommand ToDeleteMessageCommand(this DeleteMessageCommandModel model) =>
            new()
            {
                MessageId = model.MessageId
            };
    }
}