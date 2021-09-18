using System;
using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    public record EditMessageRequest
    {
        [JsonConstructor]
        public EditMessageRequest(Guid messageId, string modifiedText)
        {
            MessageId = messageId;
            ModifiedText = modifiedText;
        }

        public Guid MessageId { get; }
        public string ModifiedText { get; }
    }

    public static class EditMessageCommandMapper
    {
        public static EditMessageCommand ToCommand(this EditMessageRequest model, Guid userId)
        {
            return new()
            {
                MessageId = model.MessageId,
                ModifiedText = model.ModifiedText,
                UserId = userId
            };
        }
    }
}