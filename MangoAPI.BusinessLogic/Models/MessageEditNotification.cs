using System;
using System.ComponentModel;

namespace MangoAPI.BusinessLogic.Models
{
    public class MessageEditNotification
    {
        [DefaultValue("69930843-de66-49cd-bb3a-a905bb9fcfc2")]
        public Guid MessageId { get; init; }
        
        [DefaultValue("hello world!")]
        public string ModifiedText { get; init; }
        
        [DefaultValue("2021-11-19T18:25:43-05:00")]
        public string UpdatedAt { get; init; }
    }
}