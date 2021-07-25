using MangoAPI.DTO.ApiCommands.Messages;

namespace MangoAPI.DTO.RequestModels.Messages
{
    public class DeleteMessageRequest
    {
        public string MessageId { get; set; }
    }

    public static class DeleteMessageCommandMapper
    {
        public static DeleteMessageCommand ToCommand(this DeleteMessageRequest model) =>
            new()
            {
                MessageId = model.MessageId
            };
    }
}