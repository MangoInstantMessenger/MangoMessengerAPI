using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;
using System;

namespace MangoAPI.UnitTests.Helpers;

public static class ChatEntityHelper
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

    public static ChatEntity CreateWithImage(string image)
    {
        var chat = ChatEntity.Create(
            Title,
            CommunityType.DirectChat,
            Description,
            image,
            DateTime.UtcNow,
            membersCount: 2);

        return chat;
    }

    public static ChatEntity CreateWithMembersCount(int membersCount)
    {
        var chat = ChatEntity.Create(
            Title,
            CommunityType.DirectChat,
            Description,
            Image,
            DateTime.UtcNow,
            membersCount);

        return chat;
    }

    public static ChatEntity CreateWithTitle(string title)
    {
        var chat = ChatEntity.Create(
            title,
            CommunityType.DirectChat,
            Description,
            Image,
            DateTime.UtcNow,
            membersCount: 2);

        return chat;
    }

    public static ChatEntity CreateWithCommunityType(CommunityType communityType)
    {
        var chat = ChatEntity.Create(
            Title,
            communityType,
            Description,
            Image,
            DateTime.UtcNow,
            membersCount: 2);

        return chat;
    }

    public static ChatEntity CreateWithLastMessageText(string lastMessageText)
    {
        var chat = CreateSuccess();

        chat.UpdateLastMessage(lastMessageText, DateTime.UtcNow);

        return chat;
    }

    public static ChatEntity CreateWithLastMessageAuthor(string lastAuthor)
    {
        var chat = CreateSuccess();
        const string LastMessage = "Hello, world!";

        chat.UpdateLastMessage(lastAuthor, LastMessage, DateTime.UtcNow, Guid.NewGuid());

        return chat;
    }

    public static ChatEntity CreateSuccess()
    {
        var chat = ChatEntity.Create(
            Title,
            CommunityType.DirectChat,
            Description,
            Image,
            DateTime.UtcNow,
            membersCount: 2);

        return chat;
    }
}