using FluentValidation;
using MangoAPI.Domain.Enums;
using System;
using System.Collections.Generic;

namespace MangoAPI.Domain.Entities.ChatEntities;

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
        int membersCount)
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

        new ChatEntityValidator().ValidateAndThrow(this);
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
        new ChatEntityValidator().ValidateAndThrow(this);
    }

    public void ChangeChatImage(string fileName)
    {
        Image = fileName;
        new ChatEntityValidator().ValidateAndThrow(this);
    }

    public void UpdateLastMessage(
        string lastMessageAuthor,
        string lastMessageText,
        DateTime? lastMessageDate,
        Guid? lastMessageId)
    {
        UpdateLastMessage(lastMessageText, lastMessageDate);
        LastMessageAuthor = lastMessageAuthor;
        LastMessageId = lastMessageId;
        new ChatEntityValidator().ValidateAndThrow(this);
    }

    public void UpdateLastMessage(string lastMessageText, DateTime? lastMessageDate)
    {
        LastMessageText = lastMessageText;
        LastMessageTime = lastMessageDate;
        new ChatEntityValidator().ValidateAndThrow(this);
    }

    public void UpdateTitle(string title)
    {
        Title = title;
        new ChatEntityValidator().ValidateAndThrow(this);
    }
}