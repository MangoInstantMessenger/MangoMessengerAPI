using System;

namespace MangoAPI.BusinessLogic.Notifications;

public record TypingEventNotification(Guid UserId, Guid ChatId, string DisplayName);