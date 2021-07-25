using MangoAPI.DTO.ApiCommands.Messages;

namespace MangoAPI.DTO.CommandModels.Messages
{
    public class SendMessageCommandModel
    {
        public string MessageText { get; set; }
        public string ChatId { get; set; }
    }

    public static class SendMessageCommandMapper
    {
        public static SendMessageCommand ToSendMessageCommand(this SendMessageCommandModel model) =>
            new()
            {
                ChatId = model.ChatId,
                MessageText = model.MessageText
            };
    }
}