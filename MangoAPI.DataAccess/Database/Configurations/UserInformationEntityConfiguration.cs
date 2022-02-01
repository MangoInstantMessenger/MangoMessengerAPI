using System;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.DataAccess.Database.Configurations;

public class UserInformationEntityConfiguration : IEntityTypeConfiguration<UserInformationEntity>
{
    public void Configure(EntityTypeBuilder<UserInformationEntity> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasData(
            new UserInformationEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.PetroId,
                BirthDay = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow,
                Website = "petro.kolosov.com",
                Instagram = "petro.kolosov",
                LinkedIn = "petro.kolosov",
                Facebook = "petro.kolosov",
                Twitter = "petro.kolosov",
                Address = "Poznan, Poland",
            },
            new UserInformationEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.IlliaId,
                BirthDay = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow,
                Website = "illia.zubachov.com",
                Instagram = "illia.zubachov",
                LinkedIn = "illia.zubachov",
                Facebook = "illia.zubachov",
                Twitter = "illia.zubachov",
                Address = "Poznan, Poland",
            }, new UserInformationEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.SerhiiId,
                BirthDay = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow,
                Website = "serhii.holishevskii.com",
                Instagram = "serhii.holishevskii",
                LinkedIn = "serhii.holishevskii",
                Facebook = "serhii.holishevskii",
                Twitter = "serhii.holishevskii",
                Address = "Poznan, Poland",
            }, new UserInformationEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.ArslanbekId,
                BirthDay = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow,
                Website = "arslan.temirbekov.com",
                Instagram = "arslan.temirbekov",
                LinkedIn = "arslan.temirbekov",
                Facebook = "arslan.temirbekov",
                Twitter = "arslan.temirbekov",
                Address = "Poznan, Poland",
            },
            new UserInformationEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.SzymonId,
                BirthDay = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow,
                Website = "szymon.murawski.com",
                Instagram = "szymon.murawski",
                LinkedIn = "szymon.murawski",
                Facebook = "szymon.murawski",
                Twitter = "szymon.murawski",
                Address = "Poznan, Poland",
            },
            new UserInformationEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.KhachaturId,
                BirthDay = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow,
                Website = "khachapur.com",
                Instagram = "khachapur.mudrenych",
                LinkedIn = "khachapur.mudrenych",
                Address = "Moscow, Russia",
            },
            new UserInformationEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.RazumovskyId,
                BirthDay = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow,
                Address = "Odessa, Ukraine",
                Website = "razumovsky.com",
                Twitter = "razumovsky_r",
                Facebook = "razumovsky_r",
                Instagram = "razumovsky_r",
                LinkedIn = "razumovsky_r",
            },
            new UserInformationEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.KolbasatorId,
                BirthDay = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow,
                Website = "kolbasator.com",
                Facebook = "kolbasator",
                ProfilePicture = "profile.png",
                Address = "Saint-Petersburg, Russia",
            },
            new UserInformationEntity
            {
                Id = Guid.NewGuid(),
                UserId = SeedDataConstants.AmelitId,
                BirthDay = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow,
                Facebook = "TheMoonlightSonata",
                Instagram = "TheMoonlightSonata",
                Twitter = "TheMoonlightSonata",
                Address = "Moscow, Russia",
            });
    }
}