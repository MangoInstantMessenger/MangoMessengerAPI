using System;

namespace MangoAPI.BusinessLogic.Models
{
    public class MessageDeleteNotification
    {
        public Guid MessageId { get; set; }
        public string NewLastMessageText { get; set; }
        public string NewLastMessageTime { get; set; }
        public Guid? NewLastMessageId { get; set; }
        public string NewLastMessageAuthor { get; set; }
    }
}