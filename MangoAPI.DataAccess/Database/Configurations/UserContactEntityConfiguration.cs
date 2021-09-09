using System;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.DataAccess.Database.Configurations
{
    public class UserContactEntityConfiguration : IEntityTypeConfiguration<UserContactEntity>
    {
        public void Configure(EntityTypeBuilder<UserContactEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasData(

                // Petro Contacts
                new UserContactEntity
                {
                    Id = Guid.NewGuid(),
                    ContactId = SeedDataConstants.SzymonId,
                    UserId = SeedDataConstants.PetroId,
                },
                new UserContactEntity
                {
                    Id = Guid.NewGuid(),
                    ContactId = SeedDataConstants.IlliaId,
                    UserId = SeedDataConstants.PetroId,
                },
                new UserContactEntity
                {
                    Id = Guid.NewGuid(),
                    ContactId = SeedDataConstants.ArslanbekId,
                    UserId = SeedDataConstants.PetroId,
                },
                new UserContactEntity
                {
                    Id = Guid.NewGuid(),
                    ContactId = SeedDataConstants.SerhiiId,
                    UserId = SeedDataConstants.PetroId,
                },

                // Szymon Contacts
                new UserContactEntity
                {
                    Id = Guid.NewGuid(),
                    ContactId = SeedDataConstants.PetroId,
                    UserId = SeedDataConstants.SzymonId,
                },
                new UserContactEntity
                {
                    Id = Guid.NewGuid(),
                    ContactId = SeedDataConstants.IlliaId,
                    UserId = SeedDataConstants.SzymonId,
                },
                new UserContactEntity
                {
                    Id = Guid.NewGuid(),
                    ContactId = SeedDataConstants.ArslanbekId,
                    UserId = SeedDataConstants.SzymonId,
                },
                new UserContactEntity
                {
                    Id = Guid.NewGuid(),
                    ContactId = SeedDataConstants.SerhiiId,
                    UserId = SeedDataConstants.SzymonId,
                },

                // Illia Contacts
                new UserContactEntity
                {
                    Id = Guid.NewGuid(),
                    ContactId = SeedDataConstants.PetroId,
                    UserId = SeedDataConstants.IlliaId,
                },
                new UserContactEntity
                {
                    Id = Guid.NewGuid(),
                    ContactId = SeedDataConstants.SzymonId,
                    UserId = SeedDataConstants.IlliaId,
                },
                new UserContactEntity
                {
                    Id = Guid.NewGuid(),
                    ContactId = SeedDataConstants.ArslanbekId,
                    UserId = SeedDataConstants.IlliaId,
                },
                new UserContactEntity
                {
                    Id = Guid.NewGuid(),
                    ContactId = SeedDataConstants.SerhiiId,
                    UserId = SeedDataConstants.IlliaId,
                },

                // Serhii Contacts
                new UserContactEntity
                {
                    Id = Guid.NewGuid(),
                    ContactId = SeedDataConstants.PetroId,
                    UserId = SeedDataConstants.SerhiiId,
                },
                new UserContactEntity
                {
                    Id = Guid.NewGuid(),
                    ContactId = SeedDataConstants.SzymonId,
                    UserId = SeedDataConstants.SerhiiId,
                },
                new UserContactEntity
                {
                    Id = Guid.NewGuid(),
                    ContactId = SeedDataConstants.ArslanbekId,
                    UserId = SeedDataConstants.SerhiiId,
                },
                new UserContactEntity
                {
                    Id = Guid.NewGuid(),
                    ContactId = SeedDataConstants.IlliaId,
                    UserId = SeedDataConstants.SerhiiId,
                },

                // Arslanbek Contacts
                new UserContactEntity
                {
                    Id = Guid.NewGuid(),
                    ContactId = SeedDataConstants.PetroId,
                    UserId = SeedDataConstants.ArslanbekId,
                },
                new UserContactEntity
                {
                    Id = Guid.NewGuid(),
                    ContactId = SeedDataConstants.SzymonId,
                    UserId = SeedDataConstants.ArslanbekId,
                },
                new UserContactEntity
                {
                    Id = Guid.NewGuid(),
                    ContactId = SeedDataConstants.SerhiiId,
                    UserId = SeedDataConstants.ArslanbekId,
                },
                new UserContactEntity
                {
                    Id = Guid.NewGuid(),
                    ContactId = SeedDataConstants.IlliaId,
                    UserId = SeedDataConstants.ArslanbekId,
                },

                // Khachatur Contacts
                new UserContactEntity
                {
                    Id = Guid.NewGuid(),
                    ContactId = SeedDataConstants.RazumovskyId,
                    UserId = SeedDataConstants.KhachaturId,
                },

                // Razumovsky Contacts
                new UserContactEntity
                {
                    Id = Guid.NewGuid(),
                    ContactId = SeedDataConstants.KhachaturId,
                    UserId = SeedDataConstants.RazumovskyId,
                }, new UserContactEntity
                {
                    Id = Guid.NewGuid(),
                    ContactId = SeedDataConstants.SzymonId,
                    UserId = SeedDataConstants.RazumovskyId,
                }, new UserContactEntity
                {
                    Id = Guid.NewGuid(),
                    ContactId = SeedDataConstants.IlliaId,
                    UserId = SeedDataConstants.RazumovskyId,
                }, new UserContactEntity
                {
                    Id = Guid.NewGuid(),
                    ContactId = SeedDataConstants.KolbasatorId,
                    UserId = SeedDataConstants.RazumovskyId,
                }, new UserContactEntity
                {
                    Id = Guid.NewGuid(),
                    ContactId = SeedDataConstants.AmelitId,
                    UserId = SeedDataConstants.RazumovskyId,
                },

                // Kolbasator Contacts
                new UserContactEntity
                {
                    Id = Guid.NewGuid(),
                    ContactId = SeedDataConstants.KhachaturId,
                    UserId = SeedDataConstants.KolbasatorId,
                },

                // Amelit Contacts
                new UserContactEntity
                {
                    Id = Guid.NewGuid(),
                    ContactId = SeedDataConstants.RazumovskyId,
                    UserId = SeedDataConstants.AmelitId,
                });
        }
    }
}
