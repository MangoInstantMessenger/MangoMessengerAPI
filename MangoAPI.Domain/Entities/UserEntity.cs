using FluentValidation;
using System.Collections.Generic;
using MangoAPI.Domain.Enums;
using System;
using Uuids;

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

    public DisplayNameColour DisplayNameColour { get; private set; }

    public PersonalInformationEntity PersonalInformation { get; private set; }

    public IReadOnlyCollection<SessionEntity> Sessions => _sessions;
    private readonly List<SessionEntity> _sessions;

    public IReadOnlyCollection<MessageEntity> Messages => _messages;
    private readonly List<MessageEntity> _messages;

    public IReadOnlyCollection<UserChatEntity> UserChats => _userChats;
    private readonly List<UserChatEntity> _userChats;

    public IReadOnlyCollection<ContactEntity> Contacts => _contacts;
    private readonly List<ContactEntity> _contacts;

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
        Id = Uuid.NewMySqlOptimized().ToGuidByteLayout();
        _sessions = new List<SessionEntity>();
        _messages = new List<MessageEntity>();
        _userChats = new List<UserChatEntity>();
        _contacts = new List<ContactEntity>();

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

    public void UpdateBioAndLocation(string bio, string address)
    {
        Bio = bio;
        Address = address;

        new UserEntityValidator().ValidateAndThrow(this);
    }
}