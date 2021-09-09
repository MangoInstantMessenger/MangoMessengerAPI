using System;
using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    public record SendMessageRequest
    {
        [JsonConstructor]
        public SendMessageRequest(string messageText, Guid chatId, bool isEncrypted)
        {
            MessageText = messageText;
            ChatId = chatId;
            IsEncrypted = isEncrypted;
        }

        public string MessageText { get; }
        public Guid ChatId { get; }
        public bool IsEncrypted { get; }
    }

    public static class SendMessageCommandMapper
    {
        public static SendMessageCommand ToCommand(this SendMessageRequest request, Guid userId)
        {
            return new()
            {
                ChatId = request.ChatId,
                MessageText = request.MessageText,
                IsEncrypted = request.IsEncrypted,
                UserId = userId,
            };
        }
    }
}