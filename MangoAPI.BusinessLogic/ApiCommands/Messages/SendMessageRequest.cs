using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    public record SendMessageRequest
    {
        [JsonConstructor]
        public SendMessageRequest(string messageText, Guid chatId, bool isEncrypted, 
            string attachmentUrl)
        {
            MessageText = messageText;
            ChatId = chatId;
            IsEncrypted = isEncrypted;
            AttachmentUrl = attachmentUrl;
        }

        [DefaultValue("hello world")]
        public string MessageText { get; }
        
        [DefaultValue("a8747c37-c5ef-4a87-943c-3ee3ae0a2871")]
        public Guid ChatId { get; }
        
        [DefaultValue(false)]
        public bool IsEncrypted { get; }
        
        [DefaultValue("https://localhost:5001/Uploads/khachatur_picture.jpg")]
        public string AttachmentUrl { get; }
    }
}