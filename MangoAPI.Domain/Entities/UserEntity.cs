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

    public string Website { get; set; }

    public DateTime? Birthday { get; set; }
    
    public string Address { get; set; }

    public DisplayNameColour DisplayNameColour { get; set; }

    public ICollection<SessionEntity> Sessions { get; set; }

    public ICollection<MessageEntity> Messages { get; set; }

    public ICollection<UserChatEntity> UserChats { get; set; }

    public PersonalInformationEntity PersonalInformation { get; set; }

    public ICollection<ContactEntity> Contacts { get; set; }
}