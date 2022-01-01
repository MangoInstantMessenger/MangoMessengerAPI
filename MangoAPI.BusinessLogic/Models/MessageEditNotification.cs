using System;
using System.ComponentModel;

namespace MangoAPI.BusinessLogic.Models
{
    public class MessageEditNotification
    {
        public Guid MessageId { get; init; }

        public string ModifiedText { get; init; }

        public string UpdatedAt { get; init; }

        public bool IsLastMessage { get; init; }
    }
}