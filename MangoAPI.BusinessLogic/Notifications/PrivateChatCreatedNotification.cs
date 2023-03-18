using MangoAPI.Domain.Enums;
using System;

namespace MangoAPI.BusinessLogic.Notifications;

public record PrivateChatCreatedNotification(
    Guid ChatId,
    string Title,
    CommunityType CommunityType,
    string Description,
    int MembersCount,
    bool IsArchived,
    bool IsMember,
    string ChatLogoImageUrl);