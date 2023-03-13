using FluentValidation;
using System;

namespace MangoAPI.Domain.Entities;

public sealed class PersonalInformationEntity
{
    public Guid Id { get; private set; }

    public Guid UserId { get; private set; }

    public string Facebook { get; private set; }

    public string Twitter { get; private set; }

    public string Instagram { get; private set; }

    public string LinkedIn { get; private set; }

    public DateTime CreatedAt { get; private set; }

    public DateTime? UpdatedAt { get; private set; }

    public UserEntity User { get; private set; }

    // var userInfo = new PersonalInformationEntity { UserId = newUser.Id, CreatedAt = DateTime.UtcNow, };

    private PersonalInformationEntity()
    {
    }

    private PersonalInformationEntity(Guid userId)
    {
        UserId = userId;
        CreatedAt = DateTime.UtcNow;

        new PersonalInformationEntityValidator().ValidateAndThrow(this);
    }

    public static PersonalInformationEntity Create(Guid userId)
    {
        var personalInformation = new PersonalInformationEntity(userId);

        return personalInformation;
    }

    public void UpdateSocialInformation(string facebook, string twitter, string instagram, string linkedIn)
    {
        Facebook = facebook;
        Twitter = twitter;
        Instagram = instagram;
        LinkedIn = linkedIn;
        UpdatedAt = DateTime.UtcNow;

        new PersonalInformationEntityValidator().ValidateAndThrow(this);
    }
}