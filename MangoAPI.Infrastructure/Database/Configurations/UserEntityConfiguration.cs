using System;
using MangoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MangoAPI.Infrastructure.Database.Configurations
{
    public class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasMany(x => x.RefreshTokens)
                .WithOne(x => x.UserEntity)
                .HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.UserInformation)
                .WithOne(x => x.User)
                .HasForeignKey<UserInformationEntity>(x => x.UserId);

            builder.HasMany(x => x.Contacts)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);
            
            builder.HasData(
                new UserEntity()
                {
                    PhoneNumber = "+374 775 55 43 10",
                    DisplayName = "Khachatur Khachatryan",
                    Bio = "13 y. o. | C# pozer",
                    UserName = "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a",
                    Email = "xachulxx@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    PasswordHash = "AQAAAAEAACcQAAAAEDz1x10ejBYPaKgQAz3I61UGPBculigLAlaRQFL2EYRa6G6jm5Oge7gCg1dRmxmlRA=="
                },
                new UserEntity()
                {
                    PhoneNumber = "+48 577 615 532",
                    DisplayName = "razumovsky r",
                    Bio = "11011 y.o Dotnet Developer from $\"{cityName}\"",
                    UserName = "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b",
                    Email = "kolosovp@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    PasswordHash = "AQAAAAEAACcQAAAAEDz1x10ejBYPaKgQAz3I61UGPBculigLAlaRQFL2EYRa6G6jm5Oge7gCg1dRmxmlRA=="
                },
                new UserEntity()
                {
                    PhoneNumber = "+7 701 750 62 65",
                    DisplayName = "Мусяка Колбасяка",
                    Bio = "Колбасятор.",
                    UserName = "5b515247-f6f5-47e1-ad06-95f317a0599b",
                    Email = "kolbasator@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    PasswordHash = "AQAAAAEAACcQAAAAEDz1x10ejBYPaKgQAz3I61UGPBculigLAlaRQFL2EYRa6G6jm5Oge7gCg1dRmxmlRA=="
                },
                new UserEntity() 
                {
                    PhoneNumber = "+1 202 555 0152",
                    DisplayName = "Amelit",
                    Bio = "Дипломат",
                    UserName = "d942706b-e4e2-48f9-bbdc-b022816471f0",
                    Email = "amelit@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    PasswordHash = "AQAAAAEAACcQAAAAEDz1x10ejBYPaKgQAz3I61UGPBculigLAlaRQFL2EYRa6G6jm5Oge7gCg1dRmxmlRA=="
                }
            );
        }
    }
}