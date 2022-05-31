using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace MangoAPI.DataAccess.Database.Configurations;

public class UserContactEntityConfiguration : IEntityTypeConfiguration<UserContactEntity>
{
    public void Configure(EntityTypeBuilder<UserContactEntity> builder)
    {
        builder.ToTable(nameof(UserContactEntity), MangoDbContext.DefaultSchema);

        builder.HasKey(x => x.Id);

        builder.HasData(
            // Petro Contacts
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.SzymonId,
                UserId = SeedDataConstants.PetroId,
                CreatedAt = DateTime.UtcNow,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.IlliaId,
                UserId = SeedDataConstants.PetroId,
                CreatedAt = DateTime.UtcNow,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.ArslanbekId,
                UserId = SeedDataConstants.PetroId,
                CreatedAt = DateTime.UtcNow,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.SerhiiId,
                UserId = SeedDataConstants.PetroId,
                CreatedAt = DateTime.UtcNow,
            },

            // Szymon Contacts
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.PetroId,
                UserId = SeedDataConstants.SzymonId,
                CreatedAt = DateTime.UtcNow,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.IlliaId,
                UserId = SeedDataConstants.SzymonId,
                CreatedAt = DateTime.UtcNow,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.ArslanbekId,
                UserId = SeedDataConstants.SzymonId,
                CreatedAt = DateTime.UtcNow,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.SerhiiId,
                UserId = SeedDataConstants.SzymonId,
                CreatedAt = DateTime.UtcNow,
            },

            // Illia Contacts
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.PetroId,
                UserId = SeedDataConstants.IlliaId,
                CreatedAt = DateTime.UtcNow,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.SzymonId,
                UserId = SeedDataConstants.IlliaId,
                CreatedAt = DateTime.UtcNow,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.ArslanbekId,
                UserId = SeedDataConstants.IlliaId,
                CreatedAt = DateTime.UtcNow,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.SerhiiId,
                UserId = SeedDataConstants.IlliaId,
                CreatedAt = DateTime.UtcNow,
            },

            // Serhii Contacts
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.PetroId,
                UserId = SeedDataConstants.SerhiiId,
                CreatedAt = DateTime.UtcNow,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.SzymonId,
                UserId = SeedDataConstants.SerhiiId,
                CreatedAt = DateTime.UtcNow,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.ArslanbekId,
                UserId = SeedDataConstants.SerhiiId,
                CreatedAt = DateTime.UtcNow,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.IlliaId,
                UserId = SeedDataConstants.SerhiiId,
                CreatedAt = DateTime.UtcNow,
            },

            // Arslanbek Contacts
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.PetroId,
                UserId = SeedDataConstants.ArslanbekId,
                CreatedAt = DateTime.UtcNow,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.SzymonId,
                UserId = SeedDataConstants.ArslanbekId,
                CreatedAt = DateTime.UtcNow,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.SerhiiId,
                UserId = SeedDataConstants.ArslanbekId,
                CreatedAt = DateTime.UtcNow,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.IlliaId,
                UserId = SeedDataConstants.ArslanbekId,
                CreatedAt = DateTime.UtcNow,
            },

            // Khachatur Contacts
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.RazumovskyId,
                UserId = SeedDataConstants.KhachaturId,
                CreatedAt = DateTime.UtcNow,
            },

            // Razumovsky Contacts
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.KhachaturId,
                UserId = SeedDataConstants.RazumovskyId,
                CreatedAt = DateTime.UtcNow,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.SzymonId,
                UserId = SeedDataConstants.RazumovskyId,
                CreatedAt = DateTime.UtcNow,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.IlliaId,
                UserId = SeedDataConstants.RazumovskyId,
                CreatedAt = DateTime.UtcNow,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.KolbasatorId,
                UserId = SeedDataConstants.RazumovskyId,
                CreatedAt = DateTime.UtcNow,
            },
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.AmelitId,
                UserId = SeedDataConstants.RazumovskyId,
                CreatedAt = DateTime.UtcNow,
            },

            // Kolbasator Contacts
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.KhachaturId,
                UserId = SeedDataConstants.KolbasatorId,
                CreatedAt = DateTime.UtcNow,
            },

            // Amelit Contacts
            new UserContactEntity
            {
                Id = Guid.NewGuid(),
                ContactId = SeedDataConstants.RazumovskyId,
                UserId = SeedDataConstants.AmelitId,
                CreatedAt = DateTime.UtcNow,
            });
    }
}