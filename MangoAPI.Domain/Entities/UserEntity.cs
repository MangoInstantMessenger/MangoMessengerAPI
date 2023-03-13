using FluentValidation;
using System.Collections.Generic;
using MangoAPI.Domain.Enums;
using System;

namespace MangoAPI.Domain.Entities;

public sealed class UserEntity
{
    public Guid Id { get; private set; }

    public string Username { get; private set; }

    public byte[] PasswordHash { get; private set; }

    public byte[] PasswordSalt { get; private set; }

    public string DisplayName { get; private set; }

    public string ImageFileName { get; private set; }

    public string Bio { get; private set; }

    public string Website { get; private set; }

    public DateTime? Birthday { get; private set; }

    public string Address { get; private set; }

    private UserEntity()
    {
    }

    private UserEntity(
        string username,
        byte[] passwordHash,
        byte[] passwordSalt,
        string displayName,
        string imageFileName,
        DisplayNameColour displayNameColour)
    {
        Id = Guid.NewGuid();
        Username = username;
        PasswordHash = passwordHash;
        PasswordSalt = passwordSalt;
        DisplayName = displayName;
        ImageFileName = imageFileName;
        DisplayNameColour = displayNameColour;

        new UserEntityValidator().ValidateAndThrow(this);
    }

    public static UserEntity Create(
        string username,
        byte[] passwordHash,
        byte[] passwordSalt,
        string displayName,
        string imageFileName,
        DisplayNameColour displayNameColour)
    {
        var user = new UserEntity(
            username,
            passwordHash,
            passwordSalt,
            displayName,
            imageFileName,
            displayNameColour);

        return user;
    }

    public void UpdateProfilePicture(string imageFileName)
    {
        ImageFileName = imageFileName;
        
        new UserEntityValidator().ValidateAndThrow(this);
    }

    public void SetDisplayName(string displayName)
    {
        DisplayName = displayName;
        
        new UserEntityValidator().ValidateAndThrow(this);
    }

    public void UpdateUserData(string bio, string website, DateTime? birthday, string address, string username)
    {
        Bio = bio;
        Website = website;
        Birthday = birthday;
        Address = address;
        Username = username;
        
        new UserEntityValidator().ValidateAndThrow(this);
    }

    public void UpdatePassword(byte[] passwordHash, byte[] passwordSalt)
    {
        PasswordHash = passwordHash;
        PasswordSalt = passwordSalt;
        
        new UserEntityValidator().ValidateAndThrow(this);
    }

    public DisplayNameColour DisplayNameColour { get; private set; }

    public ICollection<SessionEntity> Sessions { get; set; }

    public ICollection<MessageEntity> Messages { get; set; }

    public ICollection<UserChatEntity> UserChats { get; set; }

    public PersonalInformationEntity PersonalInformation { get; set; }

    public ICollection<ContactEntity> Contacts { get; set; }
}