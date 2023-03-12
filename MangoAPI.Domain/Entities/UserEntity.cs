using MangoAPI.Domain.Entities.ChatEntities;
using System.Collections.Generic;
using MangoAPI.Domain.Enums;
using System;

namespace MangoAPI.Domain.Entities;

public sealed class UserEntity
{
    public Guid Id { get; set; }

    public string Username { get; set; }

    public byte[] PasswordHash { get; set; }

    public byte[] PasswordSalt { get; set; }

    public string DisplayName { get; set; }

    public string ImageFileName { get; set; }

    public string Bio { get; set; }

    public DisplayNameColour DisplayNameColour { get; set; }

    public ICollection<SessionEntity> Sessions { get; set; }

    public ICollection<MessageEntity> Messages { get; set; }

    public ICollection<UserChatEntity> UserChats { get; set; }

    public UserInformationEntity UserInformation { get; set; }

    public ICollection<UserContactEntity> Contacts { get; set; }
}