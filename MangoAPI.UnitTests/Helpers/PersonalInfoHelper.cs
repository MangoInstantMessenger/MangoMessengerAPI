using MangoAPI.Domain.Entities;
using System;

namespace MangoAPI.UnitTests.Helpers;

public static class PersonalInfoHelper
{
    public static PersonalInformationEntity CreateSuccess()
    {
        var personalInformation = PersonalInformationEntity.Create(Guid.NewGuid());

        return personalInformation;
    }

    public static PersonalInformationEntity CreateWithUserId(Guid userId)
    {
        var personalInformation = PersonalInformationEntity.Create(userId);

        return personalInformation;
    }

    public static void PersonalInfoUpdateWith(
        string facebook = "TestUserFacebook",
        string twitter = "TestUserTwitter",
        string instagram = "TestUserInstagram",
        string linkedIn = "TestUserLinkedIn")
    {
        var personalInformation = CreateSuccess();
        personalInformation.UpdateSocialInformation(facebook, twitter, instagram, linkedIn);
    }
}