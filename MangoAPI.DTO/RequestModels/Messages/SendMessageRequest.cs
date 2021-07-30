using MangoAPI.DTO.ApiCommands.Messages;

namespace MangoAPI.DTO.RequestModels.Messages
{
    public record SendMessageRequest
    {
        public string MessageText { get; set; }
        public string ChatId { get; set; }
    }

    public static class SendMessageCommandMapper
    {
        public static SendMessageCommand ToCommand(this SendMessageRequest model) =>
            new()
            {
                ChatId = model.ChatId,
                MessageText = model.MessageText
            };
    }
}