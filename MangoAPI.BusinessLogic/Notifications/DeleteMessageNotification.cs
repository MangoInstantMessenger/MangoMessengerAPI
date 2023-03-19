using System;

namespace MangoAPI.BusinessLogic.Notifications;

public record DeleteMessageNotification(
    Guid UserId,
    Guid ChatId,
    Guid DeletedMessageId,
    string NewLastMessageText,
    DateTime? NewLastMessageTime,
    Guid? NewLastMessageId,
    string NewLastMessageDisplayName,
    bool IsLastMessage);