using System;

namespace MangoAPI.BusinessLogic.Notifications;

public record MessageDeleteNotification(
    Guid ChatId,
    Guid DeletedMessageId,
    string NewLastMessageText,
    DateTime? NewLastMessageTime,
    Guid? NewLastMessageId,
    string NewLastMessageDisplayName,
    bool IsLastMessage);