using FluentValidation;
using MangoAPI.Domain.Enums;
using System;

namespace MangoAPI.Domain.Entities;

public sealed class UserChatEntity
{
    public Guid UserId { get; private set; }

    public Guid ChatId { get; private set; }

    public UserRole RoleId { get; private set; }

    public bool IsArchived { get; private set; }

    public UserEntity User { get; private set; }

    public ChatEntity Chat { get; private set; }

    private UserChatEntity()
    {
    }

    private UserChatEntity(Guid userId, Guid chatId, UserRole roleId)
    {
        UserId = userId;
        ChatId = chatId;
        RoleId = roleId;

        new UserChatEntityValidator().ValidateAndThrow(this);
    }

    public static UserChatEntity Create(Guid userId, Guid chatId, UserRole roleId)
    {
        var userChat = new UserChatEntity(userId, chatId, roleId);

        return userChat;
    }

    public void Archive()
    {
        IsArchived = !IsArchived;
    }
}