using System;
using System.Collections.Generic;
using MangoAPI.Domain.Enums;

namespace MangoAPI.Domain.Entities;

public sealed class ChatEntity
{
    public Guid Id { get; private set; }

    public string Title { get; private set; }

    public CommunityType CommunityType { get; private set; }

    public string Description { get; private set; }

    public string Image { get; private set; }

    public DateTime CreatedAt { get; private set; }

    public DateTime? UpdatedAt { get; private set; }

    public int MembersCount { get; private set; }

    public string LastMessageAuthor { get; private set; }

    public string LastMessageText { get; private set; }

    public DateTime? LastMessageTime { get; private set; }

    public Guid? LastMessageId { get; private set; }

    public ICollection<MessageEntity> Messages => _messages;
    private readonly List<MessageEntity> _messages;

    public ICollection<UserChatEntity> ChatUsers => _chatUsers;
    private readonly List<UserChatEntity> _chatUsers;

    private ChatEntity()
    {
    }

    private ChatEntity(
        string title,
        CommunityType communityType,
        string description,
        string image,
        DateTime createdAt,
        int membersCount) : base()
    {
        Title = title;
        CommunityType = communityType;
        Description = description;
        Image = image;
        CreatedAt = createdAt;
        MembersCount = membersCount;
        
        _messages = new List<MessageEntity>();
        _chatUsers = new List<UserChatEntity>();
        Id = Guid.NewGuid();
    }

    public static ChatEntity Create(
        string title,
        CommunityType communityType,
        string description,
        string image,
        DateTime createdAt,
        int membersCount)
    {
        var newChat = new ChatEntity(title, communityType, description, image, createdAt, membersCount);

        return newChat;
    }

    public void IncrementMembersCount(int value)
    {
        MembersCount += value;
    }

    public void ChangeChatImage(string fileName)
    {
        Image = fileName;
    }

    public void UpdateLastMessage(
        string lastMessageAuthor,
        string lastMessageText,
        DateTime? lastMessageTime,
        Guid? lastMessageId)
    {
        LastMessageAuthor = lastMessageAuthor;
        LastMessageText = lastMessageText;
        LastMessageTime = lastMessageTime;
        LastMessageId = lastMessageId;
    }

    public void UpdateLastMessage(string lastMessageText, DateTime lastMessageDate)
    {
        LastMessageText = lastMessageText;
        LastMessageTime = lastMessageDate;
    }

    public void UpdateTitle(string title)
    {
        Title = title;
    }

    // var channel = new ChatEntity
    // {
    //     CommunityType = CommunityType.PublicChannel,
    //     Title = request.ChannelTitle,
    //     CreatedAt = DateTime.UtcNow,
    //     Description = request.ChannelDescription,
    //     MembersCount = 1,
    //     Image = "default_group_logo.png",
    // };
}