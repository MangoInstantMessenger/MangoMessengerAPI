using System;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.DataAccess.Database.Configurations
{
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
                    BirthDay = new DateTime(1994, 6, 12),
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
                    BirthDay = new DateTime(1994, 6, 12),
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
                    BirthDay = new DateTime(1994, 6, 12),
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
                    BirthDay = new DateTime(1994, 6, 12),
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
                    BirthDay = new DateTime(1983, 5, 25),
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
                    BirthDay = new DateTime(2008, 3, 7),
                    Website = "khachapur.com",
                    Instagram = "khachapur.mudrenych",
                    LinkedIn = "khachapur.mudrenych",
                    Address = "Moscow, Russia",
                },
                new UserInformationEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.RazumovskyId,
                    BirthDay = new DateTime(1994, 7, 21),
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
                    Website = "kolbasator.com",
                    Facebook = "kolbasator",
                    ProfilePicture = "profile.png",
                    Address = "Saint-Petersburg, Russia",
                },
                new UserInformationEntity
                {
                    Id = Guid.NewGuid(),
                    UserId = SeedDataConstants.AmelitId,
                    Facebook = "TheMoonlightSonata",
                    Instagram = "TheMoonlightSonata",
                    Twitter = "TheMoonlightSonata",
                    Address = "Moscow, Russia",
                });
        }
    }
}
