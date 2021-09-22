using System;
using System.ComponentModel;
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

        [DefaultValue("c5a73134-434f-4ce8-bd91-d945e15673c5")]
        public Guid MessageId { get; }
        
        [DefaultValue("test message")]
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