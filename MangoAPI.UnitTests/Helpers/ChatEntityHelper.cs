using MangoAPI.Domain.Entities.ChatEntities;
using MangoAPI.Domain.Enums;
using System;

namespace MangoAPI.UnitTests.Helpers;

public class ChatEntityHelper
{
    public const string Title = "Mango Messenger";
    public const string Description = "Service notifications";
    public const string Image = "mango_image.png";

    public static ChatEntity CreateWithDescription(string description)
    {
        var chat = ChatEntity.Create(
            Title,
            CommunityType.DirectChat,
            description,
            Image,
            DateTime.UtcNow,
            membersCount: 2);

        return chat;
    }
}