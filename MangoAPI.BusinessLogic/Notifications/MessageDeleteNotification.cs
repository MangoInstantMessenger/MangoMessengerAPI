using System;

namespace MangoAPI.BusinessLogic.Notifications;

// public record MessageDeleteNotification
// {
//     public Guid ChatId { get; set; }
//     public Guid DeletedMessageId { get; set; }
//
//     public string NewLastMessageText { get; set; }
//
//     public DateTime? NewLastMessageTime { get; set; }
//
//     public Guid? NewLastMessageId { get; set; }
//
//     public string NewLastMessageAuthor { get; set; }
//
//     public bool IsLastMessage { get; set; }
// }

public record MessageDeleteNotification(
    Guid ChatId,
    Guid DeletedMessageId,
    string NewLastMessageText,
    DateTime? NewLastMessageTime,
    Guid? NewLastMessageId,
    string NewLastMessageDisplayName,
    bool IsLastMessage);