using System;

namespace MangoAPI.BusinessLogic.Notifications;

public record PrivateChatDeletedNotification(Guid ChatId);