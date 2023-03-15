using System;

namespace MangoAPI.BusinessLogic.Models;

public record MessageDeleteNotification
{
    public Guid ChatId { get; set; }
    public Guid DeletedMessageId { get; set; }

    public string NewLastMessageText { get; set; }

    public DateTime? NewLastMessageTime { get; set; }

    public Guid? NewLastMessageId { get; set; }

    public string NewLastMessageAuthor { get; set; }

    public bool IsLastMessage { get; set; }
}