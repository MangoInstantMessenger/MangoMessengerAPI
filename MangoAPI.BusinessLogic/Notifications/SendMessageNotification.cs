using MangoAPI.Domain.Enums;
using System;

namespace MangoAPI.BusinessLogic.Notifications;

public record SendMessageNotification(
    Guid MessageId,
    Guid UserId,
    Guid ChatId,
    string DisplayName,
    DisplayNameColour DisplayNameColour,
    string Text,
    DateTime CreatedAt,
    DateTime? UpdatedAt,
    string InReplyToUser,
    string InReplyToText,
    string AuthorImageUrl,
    string AttachmentUrl);